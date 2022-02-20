using News_Model.AdminModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace News_AppProces
{
    public class CallWebServices
    {
        public Setting GetAppInfo(string appGuidId)
        {

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("http://mobilewebservice.gearhostpreview.com/api/App/GetAppInfo?AppGuidId="+ appGuidId);
            Setting setting = new Setting();
            setting = JsonConvert.DeserializeObject<Setting>(result);
            return setting;
        }

    }
}

