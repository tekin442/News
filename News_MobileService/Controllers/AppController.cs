using News_MobileService.Business;
using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_MobileService.Controllers
{
    public class AppController : ApiController
    {
        public Setting GetAppInfo(string AppGuidId)
        {
            ClientBusiness business = new ClientBusiness();
           return  business.GetAppInfo(AppGuidId);
        }
    }
}
