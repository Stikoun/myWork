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
    [Table("Visit")]
    public class Visit
    {
        [Key]
        [Browsable(false)]
        public int idVisit { get; set; }

        [Browsable(false)]
        public int idCase { get; set; }

        public DateTime VisitDate { get; set; }

        public string Description { get; set; }
    }
}
