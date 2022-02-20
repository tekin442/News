using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Model.NewsModel
{
    public class Categori
    {
        public int ID { get; set; }
        public int MainCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
    }
}
