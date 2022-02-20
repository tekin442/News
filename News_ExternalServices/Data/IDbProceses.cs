using News_Model.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_ExternalServices.Data
{
    interface IDbProceses
    {
        List<Categori> GetCategories();
        List<Comment> GetComents(int ContentId);
        Content GetContent(int ContentId);
        List<LastMuniteSubCategori> GetLastMuniteSubCategories();
        List<MainPageSliderNew> GetMainPageSliderNew();
        List<SubCategori> GetSubCategori(int CategoryId);
        List<WriterSubCategori> GetWriterSubCategories(int WriteId);
        Write GetWrite(int WriteId);
    }
}
