using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol
{
    [Serializable]
    public class Measurement : IHtmlSavable
    {
        [DisplayName("Parametr")]
        public string Parameter { get; set; } = "";
        [DisplayName("Hodnota")]
        public double Value { get; set; } = 0.0;
        [DisplayName("Jednotka")]
        public string Unit { get; set; } = "";
        [DisplayName("Vyhovuje")]
        public bool Passing { get; set; }

        public string ConvertToHtml()
        {
            return @"<tr><td>"+Parameter+@"</td><td>"+Value+@"</td><td>"+Unit+@"</td><td>"+(Passing ? "Ano" : "Ne")+@"</td></tr>";
        }

        public string DefineCssStyle()
        {
            return "";
        }
    }
}
