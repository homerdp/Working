using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Working.Domain.Core;

namespace Working.Infstructure.Data
{
    public class WorkingDbContext : DbContext
    {
        public WorkingDbContext() : base("name=WorkingDbContext")
        {
            Database.SetInitializer<WorkingDbContext>(new DataInitializer());
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<EmployeProject> EmployeProjects { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<EmployeProject>().HasKey(k => k.EmployeId).HasKey(c => c.ProjectId);
            modelBuilder.Entity<Employe>().HasMany(c => c.EmployesProjects).WithRequired(c => c.Employe);
            modelBuilder.Entity<Project>().HasMany(c => c.EmployesProjects).WithRequired(c => c.Project);
            

        }
    }
}
