using News_Data.DatabaseBusines;
using News_Data.Entity;
using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace News_MobileService.Business
{
    public class ClientBusiness
    {
        public Setting GetAppInfo(string AppGuidId)
        {
            Setting settingModel = new Setting();
            DatabaseAdo databaseAdo = new DatabaseAdo();
            DataTable dt =  databaseAdo.GetAppInfo(AppGuidId);

            settingModel.SettingId = Convert.ToInt32(dt.Rows[0]["SettingId"]);
            settingModel.AppName = dt.Rows[0]["AppName"].ToString();
            settingModel.LogoUrl = dt.Rows[0]["LogoUrl"].ToString();
            settingModel.AcilisFileUrl = dt.Rows[0]["AcilisFileUrl"].ToString();
            settingModel.WebServiceUrl = dt.Rows[0]["WebServiceUrl"].ToString();
            settingModel.TemplateId = Convert.ToInt32( dt.Rows[0]["TemplateId"].ToString());
            settingModel.AdmobBannerCode = dt.Rows[0]["AdmobBannerCode"].ToString();
            settingModel.AdmobSplashCode = dt.Rows[0]["AdmobSplashCode"].ToString();
            settingModel.TemplateArea1 = dt.Rows[0]["TemplateArea1"].ToString();
            settingModel.TemplateArea2 = dt.Rows[0]["TemplateArea2"].ToString();
            settingModel.TemplateArea3 = dt.Rows[0]["TemplateArea3"].ToString();
            settingModel.TemplateArea4 = dt.Rows[0]["TemplateArea4"].ToString();
            settingModel.TemplateArea5 = dt.Rows[0]["TemplateArea5"].ToString();
            settingModel.TemplateArea6 = dt.Rows[0]["TemplateArea6"].ToString();
            settingModel.TemplateArea7 = dt.Rows[0]["TemplateArea7"].ToString();
            settingModel.TemplateArea8 = dt.Rows[0]["TemplateArea8"].ToString();
            settingModel.TemplateArea9 = dt.Rows[0]["TemplateArea9"].ToString();
            settingModel.TemplateArea10 = dt.Rows[0]["TemplateArea10"].ToString();
            settingModel.TemplateArea11 = dt.Rows[0]["TemplateArea11"].ToString();
            settingModel.TemplateArea12 = dt.Rows[0]["TemplateArea12"].ToString();
            settingModel.TemplateArea13 = dt.Rows[0]["TemplateArea13"].ToString();
            settingModel.TemplateArea14 = dt.Rows[0]["TemplateArea14"].ToString();
            settingModel.TemplateArea15 = dt.Rows[0]["TemplateArea15"].ToString();
            settingModel.UserId = Convert.ToInt32( dt.Rows[0]["UserId"].ToString());
            settingModel.AppGuid = dt.Rows[0]["AppGuid"].ToString();

            return settingModel;
        }
    }
}