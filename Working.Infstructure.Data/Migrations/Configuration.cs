using System.Collections.Generic;
using Working.Domain.Core;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Working.Infstructure.Data.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<Working.Infstructure.Data.WorkingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Working.Infstructure.Data.WorkingDbContext context)
        {
            context.Employes.AddOrUpdate(e => e.EmployeId,
                new Employe() { EmployeId = 1, Name = "Homer" },
                new Employe() { EmployeId = 2, Name = "Bart" },
                new Employe() { EmployeId = 3, Name = "Bender" },
                new Employe() { EmployeId = 4, Name = "Fry" });
           
            context.Projects.AddOrUpdate(p => p.ProjectId,
                new Project() { ProjectId = 1, Name = "project1" },
                new Project() { ProjectId = 2, Name = "project2" },
                new Project() { ProjectId = 3, Name = "project3" },
                new Project() { ProjectId = 4, Name = "project4" }
                );
           

            context.EmployeProjects.AddOrUpdate(e => e.EmployeProjectId,
                new EmployeProject() { EmployeProjectId = 1, EmployeId = 1, ProjectId = 1, DateStart = new DateTime(2016, 11, 4), DateEnd = new DateTime(2016, 11, 10) },
                 new EmployeProject() { EmployeProjectId = 2, EmployeId = 1, ProjectId = 2, DateStart = new DateTime(2016, 10, 4), DateEnd = new DateTime(2016, 11, 12) },
                  new EmployeProject() { EmployeProjectId = 3, EmployeId = 2, ProjectId = 1, DateStart = new DateTime(2016, 11, 7), DateEnd = new DateTime(2016, 11, 10) },
                   new EmployeProject() { EmployeProjectId = 4, EmployeId = 3, ProjectId = 2, DateStart = new DateTime(2016, 10, 11), DateEnd = new DateTime(2016, 11, 17) },
                   new EmployeProject() { EmployeProjectId = 5, EmployeId = 3, ProjectId = 1, DateStart = new DateTime(2016, 10, 11), DateEnd = new DateTime(2016, 11, 17) }
                   );
           
        }
    }
}
