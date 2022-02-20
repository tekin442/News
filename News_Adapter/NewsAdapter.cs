using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace News_Adapter
{
    public class NewsAdapter
    {
        CallExternalService callExternalService;
        public List<Categori> getAllCategoires(string baseUrl, string actionName)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return  JsonConvert.DeserializeObject<List<Categori>>(callExternalService.parseJson());
        }

        public List<Comment> GetComents(string baseUrl, string actionName, int ContentId)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<List<Comment>>(callExternalService.parseCommentJson(ContentId));
        }

        public List<LastMuniteSubCategori> GetLastMuniteSubCategories(string baseUrl, string actionName)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<List<LastMuniteSubCategori>>(callExternalService.parseJson());
        }

        public List<MainPageSliderNew> GetMainPageSliderNew(string baseUrl, string actionName)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<List<MainPageSliderNew>>(callExternalService.parseJson());
        }

        public List<SubCategori> GetSubCategori(string baseUrl, string actionName, int CategoryId)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<List<SubCategori>>(callExternalService.parseSubCategoriJson(CategoryId));
        }

        public Write GetWrite(string baseUrl, string actionName, int WriteId)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<Write>(callExternalService.parseWriteJson(WriteId));
        }

        public Content GetContent(string baseUrl, string actionName, int ContentId)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<Content>(callExternalService.parseCommentJson(ContentId));
        }

        public List<WriterSubCategori> GetWriterSubCategories(string baseUrl, string actionName)
        {
            callExternalService = new CallExternalService(baseUrl, actionName);
            return JsonConvert.DeserializeObject<List<WriterSubCategori>>(callExternalService.parseJson());
        }
    }
}
