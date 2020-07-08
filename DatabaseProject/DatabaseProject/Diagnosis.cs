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
    [Table("Diagnosis")]
    public class Diagnosis
    {
        [Key]
        [Browsable(false)]
        public int idDiagnosis { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}
