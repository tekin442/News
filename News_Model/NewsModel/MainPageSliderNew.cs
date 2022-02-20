using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Model.NewsModel
{
    public class MainPageSliderNew
    {
        public int ID { get; set; }
        public int ContentID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImgPath { get; set; }
        public int SliderOrder { get; set; }
    }
}
