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
    [Table("Patient")]
    public class Patient
    {
        [Key]
        [Browsable(false)]
        public int idPatient { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public string PIN { get; set; }

        public DateTime Birth { get; set; }

        public string Insurence { get; set; }

        public string Residence { get; set; }

        public string Nationality { get; set; }

        public string Anamnesis { get; set; }

        public string Note { get; set; }
    }
}
