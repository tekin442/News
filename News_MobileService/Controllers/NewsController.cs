using News_Adapter;
using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_MobileService.Controllers
{
    public class NewsController : ApiController
    {
        string baseUrl = "http://externalwebservice.gearhostpreview.com/api/News/";
        NewsAdapter newsAdapter;
        public List<Categori> GetAllCategories()
        {
            newsAdapter = new NewsAdapter(); 
            return newsAdapter.getAllCategoires(baseUrl, "GetCategories");
        }

        public List<Comment> GetComents(int ContentId)
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetComents(baseUrl, "GetComents",1);
        }

        public List<LastMuniteSubCategori> GetLastMuniteSubCategories()
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetLastMuniteSubCategories(baseUrl, "GetLastMuniteSubCategories");
        }

        public List<MainPageSliderNew> GetMainPageSliderNew()
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetMainPageSliderNew(baseUrl, "GetMainPageSliderNew");
        }

        public List<SubCategori> GetSubCategori(int CategoryId)
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetSubCategori(baseUrl, "GetSubCategori", CategoryId);
        }

        public Content GetContent(int ContentId)
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetContent(baseUrl, "GetContent", ContentId);
        }

        public Write GetWrite(int WriteId)
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetWrite(baseUrl, "GetWrite", WriteId);
        }

        public List<WriterSubCategori> GetWriterSubCategories()
        {
            newsAdapter = new NewsAdapter();
            return newsAdapter.GetWriterSubCategories(baseUrl, "GetWriterSubCategories");
        }
    }
}
