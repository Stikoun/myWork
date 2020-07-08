using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Table("DiagnosisDrugs")]
    public class DiagnosisDrugs
    {

        public int idDiagnosis { get; set; }
        [Key]
        public int idDrug { get; set; }

        [NotMapped]
        public string DiagnosisName { get; set; }

        [NotMapped]
        public string DrugName { get; set; }
    }
}
