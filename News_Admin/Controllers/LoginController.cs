using News_Admin.Business;
using News_Admin.Models;
using News_Data.Entity;
using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News_Admin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                ClientBusiness business = new ClientBusiness();

                AdminPanelListModel adminPanelListModel = (business.Login(model));
                if (adminPanelListModel.user.RoleId != 0)
                {
                    Session["UserInfo"] = adminPanelListModel.user;
                    Session["LogedUserAppList"] = adminPanelListModel;
                    return RedirectToAction("UserPanel", "Login", null);
                }
                else
                {
                    ViewBag.Message = string.Format("Kullanıcı Adı Yada Şifre Yanlış.");
                }
            }
            return View(model);
        }

        public ActionResult UserPanel()
        {
            AdminPanelListModel model = Session["LogedUserAppList"]  as AdminPanelListModel;
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(User model)
        {
            if (ModelState.IsValid)
            {
                ClientBusiness business = new ClientBusiness();
                if (business.AddUser(model))
                {
                    ViewBag.Message = string.Format("Kullanıcı Eklendi.");
                }
                else
                {
                    ViewBag.Message = string.Format("Kullanıce Eklenmedi.");
                }
            }

            return View(model);
        }

        public ActionResult AddNewApplication()
        {
            return RedirectToAction("AddApplication", "Login", new { SettingId = 0 });
        }


        public ActionResult AddApplication(int SettingId)
        {
            ClientBusiness business = new ClientBusiness();

            AdminPanelListModel adminPanelListModel = null;
            if (SettingId != 0)
            {
                adminPanelListModel = business.GetSettingDetail(SettingId);
            }
            else
            {
                adminPanelListModel = new AdminPanelListModel();
            }

            adminPanelListModel.templateList = business.SetTemplate();

            return View(adminPanelListModel);
        }

        [HttpPost]
        public ActionResult AddApplication(AdminPanelListModel model, HttpPostedFileBase filelogo, HttpPostedFileBase fileacilis)
        {
            ClientBusiness business = new ClientBusiness();
            AdminPanelListModel userModel = Session["LogedUserAppList"] as AdminPanelListModel;

            if (filelogo != null && filelogo.ContentLength > 0)
            {
                string fileExtention = filelogo.ContentType.Split('/')[1].ToLower();
                if (fileExtention!="png")
                {
                    model.templateList = business.SetTemplate();
                    TempData["SuccessMessage"] = "Logo dosya uzantısı .png olmalıdır.";
                    return View(model);
                }

                
                if (fileExtention != "png")
                {
                    model.templateList = business.SetTemplate();
                    TempData["SuccessMessage"] = "Logo dosya uzantısı .png olmalıdır.";
                    return View(model);
                }

                model.setting.AppGuid = model.setting.AppGuid == null ? Guid.NewGuid().ToString() : model.setting.AppGuid;
                string filelogostr = model.setting.AppGuid + "." + filelogo.ContentType.Split('/')[1];
                var path = Path.Combine(Server.MapPath("~/UploadedFiles/Logos"), filelogostr);

                System.Drawing.Image imageLogo = System.Drawing.Image.FromFile(path);
                if(imageLogo.Width!=80 && imageLogo.Height !=40)
                {
                    model.templateList = business.SetTemplate();
                    TempData["SuccessMessage"] = "Logo resim genişliği 80, yüksekliği 40 olmalıdır..";
                    return View(model);
                }

                filelogo.SaveAs(path);
                model.setting.LogoUrl = filelogostr;
            }
            else
            {
                if (model.setting.SettingId != 0)
                {
                    NewsContext db = new NewsContext();
                    var setting = db.Setting.Where(s=> s.SettingId==model.setting.SettingId).FirstOrDefault();
                    model.setting.LogoUrl = setting.LogoUrl;
                }
            }

            if (fileacilis != null && fileacilis.ContentLength > 0)
            {
                string fileExtention = fileacilis.ContentType.Split('/')[1].ToLower();
                if (fileExtention != "png")
                {
                    model.templateList = business.SetTemplate();
                    TempData["SuccessMessage"] = "Splash dosya uzantısı .png olmalıdır.";
                    return View(model);
                }
                model.setting.AppGuid = model.setting.AppGuid == null ? Guid.NewGuid().ToString() : model.setting.AppGuid;
                string fileacilisstr = model.setting.AppGuid + "." + fileacilis.ContentType.Split('/')[1];
                var path = Path.Combine(Server.MapPath("~/UploadedFiles/Splash"), fileacilisstr);
                fileacilis.SaveAs(path);
                model.setting.AcilisFileUrl = fileacilisstr;
            }
            else
            {
                if (model.setting.SettingId != 0)
                {
                    NewsContext db = new NewsContext();
                    var setting = db.Setting.Where(s => s.SettingId == model.setting.SettingId).FirstOrDefault();
                    model.setting.AcilisFileUrl = setting.AcilisFileUrl;
                }
            }

            Session["LogedUserAppList"] = business.SaveSettings(model, userModel);

            TempData["SuccessMessage"] = "İşleminiz başarı ile gerçekleşmiştir.";
            return View(model);
        }

        public ActionResult Logout()
        {
            Session["LogedUserAppList"] = null;
            return RedirectToAction("Login", "Login");
        }


        public ActionResult DeleteApplication(int SettingId)
        {
            ClientBusiness business = new ClientBusiness();
            User userModel = Session["UserInfo"] as User;

            Session["LogedUserAppList"] = business.DeleteApplication(SettingId, userModel);
            return  RedirectToAction("UserPanel","Login",null);
        }
    }
}