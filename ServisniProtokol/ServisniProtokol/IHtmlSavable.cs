using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol
{
    public interface IHtmlSavable
    {
        string ConvertToHtml();
        string DefineCssStyle();
    }
}
