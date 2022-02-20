using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Model.NewsModel
{
    public class Write
    {
        public int ID { get; set; }
        public int WriteID { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public string WriteTitle { get; set; }
        public string WriteDate { get; set; }
        public string WriteContent { get; set; }
    }
}
