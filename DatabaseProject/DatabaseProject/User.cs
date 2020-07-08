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
    [Table("User")]
    public class User
    {
        [Key]
        [Browsable(false)]
        public int idUser { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool isAdmin { get; set; }
    }
}
