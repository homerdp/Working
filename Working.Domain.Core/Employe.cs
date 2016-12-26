using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working.Domain.Core
{
    public class Employe
    {
        public int EmployeId { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeProject> EmployesProjects { get; set; }

    }
}
