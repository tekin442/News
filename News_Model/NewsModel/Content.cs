using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Model.NewsModel
{
    public class Content
    {
        public int ID { get; set; }
        public int ContentID { get; set; }
        public int CategoryID { get; set; }
        public string Text { get; set; }
        public string CreatedDate { get; set; }
    }
}
