using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Admin.Models
{
    public class AdminPanelListModel
    {
        public User user { get; set; }
        public Setting setting { get; set; }
        public IEnumerable<Setting> settingList { get; set; } 
        public IEnumerable<SelectedListItem> templateList { get; set; }
}

    public class SelectedListItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }
}