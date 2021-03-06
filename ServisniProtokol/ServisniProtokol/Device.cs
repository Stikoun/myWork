﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol
{
    [Serializable]
    public class Device : IHtmlSavable
    {
        public string Manufacturer { get; set; } = "";
        public string Model { get; set; } = "";
        public string SerialNumber { get; set; } = "";

        public string ConvertToHtml()
        {
            return @"<div id='device'>Vyrobce:"+Manufacturer+@"<br>Model:"+Model+@"<br>Vyrobni cislo:"+SerialNumber+@"</div>";
        }

        public string DefineCssStyle()
        {
            return @"#device{border: 1px solid;}";
        }
    }
}
