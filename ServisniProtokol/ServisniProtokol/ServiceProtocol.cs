using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    [Serializable]
    public class ServiceProtocol : IRenderable, IHtmlSavable
    {
        public string Number { get; set; } = "";
        public DateTime Date { get; set; } = new DateTime();
        public Customer Customer { get; set; } = new Customer();
        public Device Device { get; set; } = new Device();
        public List<Measurement> Measurements { get; set; } = new List<Measurement>();

        public bool Passing()
        {
            return !Measurements.Any(x => !x.Passing);
        }
        public string ConvertToHtml()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append(@"<html>
<head>
    <style>
        html{
            width:400px;
            margin:auto;
        }
        #left{
            float:left;
        }
        #right{
            float:right;
            width:50%;          
        }
        #bottom{
            clear:both;
        }
        table{
            width:100%;
        }
        #protocol{
            border: 1px solid;
        }
" + Customer.DefineCssStyle() + Device.DefineCssStyle() + @"
    </style>
</head>
<body>
    <div id='left'>
        <div id='protocol'>
             Cislo protokolu: " + Number + @" <br />
             Datum Protokolu: " + Date.ToShortDateString() + @"
         </div>
         <br />
         " + Device.ConvertToHtml() + @"
      </div>  
      <div id = 'right'>  
           " + Customer.ConvertToHtml() + @"   
        </div>
        <div id = 'bottom'>     
             <br />    
             <hr />    
             <center> Zarizeni " + (Passing() ? "vyhovuje" : "nevyhovuje") + @" </center>      
                <table>        
                    <tr>        
                        <th>Parametr</th>       
                        <th>Hodnota</th>       
                        <th>Jednotka</th>        
                        <th>Vyhovuje</th>       
                    </tr>        
                    <tr>");
            foreach (Measurement measurement in Measurements)
            {
                sr.Append(measurement.ConvertToHtml());
            }
            sr.Append(@"      
                    </tr>    
                </table>       
            </div>
        </body>
        </html>");

            return sr.ToString();
        }

        public string DefineCssStyle()
        {
            return "";
        }

        public void Render(Graphics g)
        {
            Font f = new Font(FontFamily.GenericSansSerif, 10);

            g.DrawRectangle(Pens.Black, 10, 10, 200, 40);
            TextRenderer.DrawText(g, "Cislo protokolu: " + Number, f, new Point(12, 12), Color.Black);
            TextRenderer.DrawText(g, "Datum protokolu: " + Date.ToShortDateString(), f, new Point(12, 30), Color.Black);

            g.DrawRectangle(Pens.Black, 230, 10, 200, 130);
            TextRenderer.DrawText(g, "Jmeno: " + Customer.Name, f, new Point(232, 12), Color.Black);
            TextRenderer.DrawText(g, "Adresa:\n" + Customer.Address, f, new Point(232, 30), Color.Black);
            TextRenderer.DrawText(g, "PSC: " + Customer.ZIP, f, new Point(232, 100), Color.Black);
            TextRenderer.DrawText(g, "IC: " + Customer.IC, f, new Point(232, 120), Color.Black);

            g.DrawRectangle(Pens.Black, 10, 60, 200, 60);
            TextRenderer.DrawText(g, "Vyrobce: " + Device.Manufacturer, f, new Point(12, 62), Color.Black);
            TextRenderer.DrawText(g, "Model: " + Device.Model, f, new Point(12, 80), Color.Black);
            TextRenderer.DrawText(g, "Seriove cislo: " + Device.SerialNumber, f, new Point(12, 100), Color.Black);

            g.DrawLine(Pens.Black, 10, 150, 430, 150);

            TextRenderer.DrawText(g, "Zarizeni " + (Passing() ? "vyhovuje" : "nevyhovuje"), f, new Point(170, 150), Color.Black);

            TextRenderer.DrawText(g, "Parametr", f, new Point(12, 170), Color.Black);
            TextRenderer.DrawText(g, "Hodnota", f, new Point(112, 170), Color.Black);
            TextRenderer.DrawText(g, "Jednotka", f, new Point(212, 170), Color.Black);
            TextRenderer.DrawText(g, "Vyhovuje", f, new Point(312, 170), Color.Black);

            for (int i = 0; i < Measurements.Count; i++)
            {
                TextRenderer.DrawText(g, Measurements[i].Parameter, f, new Point(12, 190 + 20 * i), Color.Black);
                TextRenderer.DrawText(g, Measurements[i].Value.ToString(), f, new Point(112, 190 + 20 * i), Color.Black);
                TextRenderer.DrawText(g, Measurements[i].Unit, f, new Point(212, 190 + 20 * i), Color.Black);
                TextRenderer.DrawText(g, (Measurements[i].Passing ? "Ano" : "Ne"), f, new Point(312, 190 + 20 * i), Color.Black);

                g.DrawLine(Pens.Black, 10, 210 + i * 20, 430, 210 + i * 20);
            }
        }
    }
}
