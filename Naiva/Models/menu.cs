using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Naiva.Models
{
    public class menu
    {
        public static List<IndexMenu> GetIndexMenus()
        { 
        List<IndexMenu> menuList = new List<IndexMenu>
        {
            new IndexMenu {Id = "MyApplication" },
            new IndexMenu {Id = "MyOtherApp" },
            new IndexMenu {Id = "MyCV" }

        };
        return menuList;
    }
}

    public class IndexMenu
    {
        public String Id { get; set; }
    }
}