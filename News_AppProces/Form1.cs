using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace News_AppProces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppProcess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGuid.Text))
            {
                string mainUrl = "http://newsadminpanel.gearhostpreview.com/";
                CallWebServices callWebService = new CallWebServices();
                var result = callWebService.GetAppInfo(txtGuid.Text.Trim());
                result.LogoUrl = mainUrl + "UploadedFiles/Logos/" + result.LogoUrl;
                result.AcilisFileUrl = mainUrl + "UploadedFiles/Splash/" + result.AcilisFileUrl;

                if (!string.IsNullOrEmpty(result.LogoUrl))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFileAsync(new Uri(result.LogoUrl), @"C:\Users\jiyan\ReactNativeProjects\NewsApp\img\logo.png");
                    }
                }

                if (!string.IsNullOrEmpty(result.AcilisFileUrl))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFileAsync(new Uri(result.AcilisFileUrl), @"C:\Users\jiyan\ReactNativeProjects\NewsApp\img\splash.png");
                    }
                }

                if (!string.IsNullOrEmpty(result.AppName))
                {
                    changeAppSetting(result.AppName);
                }


                lblExplain.Text = "İşleminiz başarı ile gerçekleşti.";
            }
            else
            {
                lblExplain.Text = "Lütfen Uygulama kodunu giriniz.";
            }
        }

        private void changeAppSetting(string appName)
        {
            string appSettingUrl = @"C:\Users\jiyan\ReactNativeProjects\NewsApp\android\app\src\main\res\values\strings.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(appSettingUrl);

            XmlNodeList aDateNodes = doc.SelectNodes("/resources/string");
            foreach (XmlNode aDateNode in aDateNodes)
            {
                XmlAttribute DateAttribute = aDateNode.Attributes["string"];
                aDateNode.InnerText = appName;
            }
            doc.Save(appSettingUrl);
        }

    }
}
