using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace News_Adapter
{
    public class CallExternalService
    {
        private string _appGuidId;
        private string _baseUrl;
        private string _actionName;
        WebClient client;
        public CallExternalService( string baseUrl, string actionName)
        {
            _baseUrl = baseUrl;
            _actionName = actionName;
        }


        public string parseJson()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string result = client.DownloadString(_baseUrl+_actionName);
            return result;
        }

        public string parseCommentJson(int ContentId)
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString(_baseUrl + _actionName + "?ContentId=" + ContentId);
            
            return result;
        }

        public string parseSubCategoriJson(int CategoryId)
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString(_baseUrl + _actionName + "?CategoryId=" + CategoryId);
            return result;
        }

        public string parseWriteJson(int WriteId)
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString(_baseUrl + _actionName + "?WriteId=" + WriteId);
            return result;
        }

    }
}