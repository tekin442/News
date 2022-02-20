using News_Adapter;
using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_Services.Controllers
{
    public class NewsController : ApiController
    {
        NewsAdapter newsAdapter;
        public List<Categori> GetAllCategories()
        {

            newsAdapter = new NewsAdapter();
            return newsAdapter.getAllCategoires("http://localhost/api/News/", "GetCategories");
        }
    }
}
