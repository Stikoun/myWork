using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Table("Drug")]
    public class Drug
    {
        [Key]
        [Browsable(false)]
        public int idDrug { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string AdultDosage { get; set; }

        public string KinderDosage { get; set; }
    }
}
