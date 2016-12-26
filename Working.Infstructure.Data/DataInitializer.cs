using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Working.Domain.Core;

namespace Working.Infstructure.Data
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<WorkingDbContext>
    {
        protected override void Seed(WorkingDbContext context)
        {
            var employes = new List<Employe>
            {
                new Employe() {EmployeId = 1, Name = "Homer"},
                new Employe() {EmployeId = 2, Name = "Bart"},
                new Employe() {EmployeId = 3, Name = "Bender"},
                new Employe() {EmployeId = 4, Name = "Fry"}
            };
            employes.ForEach(e => context.Employes.Add(e));
            context.SaveChanges();
            
            var projects = new List<Project>()
            {
                new Project() {ProjectId = 1, Name = "project1"},
                new Project() {ProjectId = 2, Name = "project2"},
                new Project() {ProjectId = 3, Name = "project3"},
                new Project() {ProjectId = 4, Name = "project4"},
            };
            projects.ForEach( p => context.Projects.Add(p));
            context.SaveChanges();

            var employeProjects = new List<EmployeProject>()
            {
                new EmployeProject() {EmployeId = 1, ProjectId = 1,  DateStart = new DateTime(2016,11,4), DateEnd = new DateTime(2016,11,10)},
                 new EmployeProject() {EmployeId = 1, ProjectId = 2,  DateStart = new DateTime(2016,10,4), DateEnd = new DateTime(2016,11,12)},
                  new EmployeProject() {EmployeId = 2, ProjectId = 1,  DateStart = new DateTime(2016,11,7), DateEnd = new DateTime(2016,11,10)},
                   new EmployeProject() {EmployeId = 3, ProjectId = 2,  DateStart = new DateTime(2016,10,11), DateEnd = new DateTime(2016,11,17)},
            };

            employeProjects.ForEach(e => context.EmployeProjects.Add(e));
            context.SaveChanges();
        }
    }
}
