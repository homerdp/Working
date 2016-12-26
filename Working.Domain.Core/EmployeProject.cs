using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Working.Domain.Core
{
    public class EmployeProject
    {
        public int EmployeProjectId { get; set; }
        public int EmployeId { get; set; }
        public Employe Employe { get; set; }

       
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateStart { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateEnd { get; set; }

    }
}
