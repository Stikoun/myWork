using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol
{
    [Serializable]
    public class Customer : IHtmlSavable
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string ZIP { get; set; } = "";
        public string IC { get; set; } = "";

        public string ConvertToHtml()
        {
            return @"<div id='customer'>Jmeno: "+Name+@"<br />Adresa: "+Address+@"<br />PSC: "+ZIP+@"<br />IC: "+IC+@"<br /></div>";
        }

        public string DefineCssStyle()
        {
            return @"#customer{border: 1px solid;}";
        }
    }
}
