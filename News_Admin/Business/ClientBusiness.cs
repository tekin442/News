using News_Admin.Models;
using News_Data.Entity;
using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace News_Admin.Business
{
    public class ClientBusiness
    {
        NewsContext db;

        public AdminPanelListModel Login(User model)
        {
            AdminPanelListModel adminPanelListModel = null;
            db = new NewsContext();
            if (db.User.Any(s => s.UserName == model.UserName && s.Password == model.Password))
            {
                adminPanelListModel = new AdminPanelListModel();

                adminPanelListModel.user = db.User.Where(s => s.UserName == model.UserName && s.Password == model.Password).FirstOrDefault();
                adminPanelListModel.settingList = db.Setting.Where(s => s.UserId == adminPanelListModel.user.UserId).ToList();
            }
            else
            {
                // model.IsSuccessful = false;
            }
            return adminPanelListModel;
        }

        public bool AddUser(User model)
        {
            bool returnedValue = false;
            db = new NewsContext();
            model.RoleId = 1;
            if (db.User.Any(m => m.UserName == model.UserName && m.Password == model.Password && m.RoleId == model.RoleId))
            {
                returnedValue = false;
            }
            else
            {
                db.User.Add(model);
                db.SaveChanges();
                returnedValue = true;
            }

            return returnedValue;
        }

        public AdminPanelListModel GetSettingDetail(int settingId)
        {
            AdminPanelListModel adminPanelListModel = new AdminPanelListModel();
            db = new NewsContext();
            adminPanelListModel.setting = db.Setting.Where(m => m.SettingId == settingId).FirstOrDefault();

            return adminPanelListModel;
        }

        public List<SelectedListItem> SetTemplate()
        {
            List<SelectedListItem> selectedItemList = new List<SelectedListItem>();
            db = new NewsContext();
            foreach (var item in db.Template)
            {
                SelectedListItem templateItem = new SelectedListItem();
                templateItem.Text = item.Name;
                templateItem.Value = item.TemplateId;

                selectedItemList.Add(templateItem);
            }

            return selectedItemList;
        }

        public AdminPanelListModel SaveSettings(AdminPanelListModel model, AdminPanelListModel userModel)
        {
            db = new NewsContext();

            if (model.setting.TemplateId != 0)
            {
                string templateCode = db.Template.Where(m => m.TemplateId == model.setting.TemplateId).FirstOrDefault().ColorCode;
                model.setting.TemplateArea1 = templateCode;
                model.setting.TemplateArea2 = templateCode;
                model.setting.TemplateArea3 = templateCode;
                model.setting.TemplateArea4 = templateCode;
                model.setting.TemplateArea5 = templateCode;
                model.setting.TemplateArea6 = templateCode;
                model.setting.TemplateArea7 = templateCode;
                model.setting.TemplateArea8 = templateCode;
                model.setting.TemplateArea9 = templateCode;
                model.setting.TemplateArea10 = templateCode;
                model.setting.TemplateArea11 = templateCode;
                model.setting.TemplateArea12 = templateCode;
                model.setting.TemplateArea13 = templateCode;
                model.setting.TemplateArea14 = templateCode;
                model.setting.TemplateArea15 = templateCode;
               
            }
            else
            {
                model.setting.TemplateId = 0;
            }

            if (model.setting.SettingId == 0)
            {
                model.setting.UserId = userModel.user.UserId;
                model.setting.AppGuid = model.setting.AppGuid == null ? Guid.NewGuid().ToString() :model.setting.AppGuid;
                db.Setting.Add(model.setting);
                db.SaveChanges();
            }
            else
            {
                db.Entry(model.setting).State = EntityState.Modified;
                db.SaveChanges();
            }
            model.templateList = SetTemplate();

            model.settingList = db.Setting.Where(s => s.UserId == userModel.user.UserId).ToList();
            model.user = userModel.user;

            return model;
        }

        public AdminPanelListModel  DeleteApplication(int settingId, User user)
        {
            db = new NewsContext();

            var app = db.Setting.Where(x => x.SettingId == settingId).FirstOrDefault();
            db.Setting.Remove(app);
            db.SaveChanges();

            AdminPanelListModel adminPanelListModel = new AdminPanelListModel();

            adminPanelListModel.settingList = db.Setting.Where(s => s.UserId == user.UserId).ToList();
            adminPanelListModel.user = user;
            return adminPanelListModel;
        }
    }
}

