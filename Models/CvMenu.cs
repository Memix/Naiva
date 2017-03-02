using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Naiva.Models
{
    public class CvMenu
    {
        public static List<FirstMenu> GetFirstMenus()
        {
            List<FirstMenu> AdressList = new List<FirstMenu>
        {
            new FirstMenu {Id = "Ivana Leban", Address = "Ullavigatan 32b, 70357 Örebro, Sweden", Email = "leban.ivana@gmail.com", Phone = "0769313633", Skype = "ivanal123"  }
            
            

        };
            return AdressList;
        }
    }

    public class FirstMenu
    {
        [Display(Name = "FULL NAME")]
        public String Id { get; set; }
        [Display(Name = "HOME ADRESS")]
        public String Address { get; set; }
        [Display(Name = "EMAIL")]
        public String Email { get; set; }
        [Display(Name = "SKYPE")]
        public String Skype { get; set; }
        [Display(Name = "PHONE NUMBER")]
        public String Phone { get; set; }
        
    }

    
}
