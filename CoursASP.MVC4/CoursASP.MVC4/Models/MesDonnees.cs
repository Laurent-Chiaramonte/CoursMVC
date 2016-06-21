using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursASP.MVC4.Models
{
    public class MesDonnees
    {
        public string GetDonnees()
        {
            string str = String.Format("Serveur {0}, application dévelopée par {1}, " +
                "aujourd'hui {2}", "apiblj", "Barbara Le Jan", DateTime.Now.ToString("f"));
            return str;
        }
    }
}