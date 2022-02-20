using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Model.NewsModel
{
    public class WriterSubCategori
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImgPath { get; set; }
        public string WriterName { get; set; }
        public string WriteTitle { get; set; }
        public string WriteDate { get; set; }
        public int WriteOrder { get; set; }
    }
}
