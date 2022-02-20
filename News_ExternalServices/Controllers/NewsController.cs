using News_ExternalServices.Data;
using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_ExternalServices.Controllers
{
    public class NewsController : ApiController
    {
        DataProvider dataProvider;

        public List<Categori> GetCategories()
        {
            dataProvider = new DataProvider();
            return dataProvider.getCategory();
        }

        public List<Comment> GetComents(int ContentId)
        {
            dataProvider = new DataProvider();
            return dataProvider.getComment(ContentId);
        }

        public Content GetContent(int ContentId)
        {
            dataProvider = new DataProvider();
            return dataProvider.getContent(ContentId);
        }

        public List<LastMuniteSubCategori> GetLastMuniteSubCategories()
        {
            dataProvider = new DataProvider();
            return dataProvider.getLastMuniteSubCategori();
        }

        public List<MainPageSliderNew> GetMainPageSliderNew()
        {
            dataProvider = new DataProvider();
            return dataProvider.getMainPageSliderNew();
        }

        public List<SubCategori> GetSubCategori(int CategoryId)
        {
            dataProvider = new DataProvider();
            return dataProvider.getSubCategori(CategoryId);
        }

        public Write GetWrite(int WriteId)
        {
            dataProvider = new DataProvider();
            return dataProvider.getWrite(WriteId);
        }

        public List<WriterSubCategori> GetWriterSubCategories()
        {
            dataProvider = new DataProvider();
            return dataProvider.getWriterSubCategori();
        }
    }
}
