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
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        [Browsable(false)]
        public int idDoctor { get; set; }

        [Browsable(false)]
        public int idUser { get; set; }

        /*PROPERTIES FOR ALL PERSON BUT WITH USERNAME*/

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string PIN { get; set; }

        public DateTime Birth { get; set; }

        public string Gender { get; set; }

        public string Residence { get; set; }

        public string Nationality { get; set; }


    }
}
