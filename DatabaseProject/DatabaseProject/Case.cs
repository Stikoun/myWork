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
    [Table("Case")]
    public class Case
    {        
        [Key]
        public int idCase { get; set; }

        [Browsable(false)]
        public int idDoctor { get; set; }

        [Browsable(false)]
        public int idPatient { get; set; }

        [Browsable(false)]
        public int idDiagnosis { get; set; }

        public string Doctor { get; set; }

        public string Patient { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
