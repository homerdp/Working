select count(Employes.EmployeId) as counts from Employes  join ProjectEmployes on Employes.EmployeId = ProjectEmployes.Employe_EmployeId  join Projects 
on ProjectEmployes.Project_ProjectId = Projects.ProjectId where Projects.Name = 'Project1' and ProjectEmployes.Date_Start > '2016-11-11' 
and ProjectEmployes.Date_End < '2016-11-14';

select ProjectEmployes.Date_Start as start_project, ProjectEmployes.Date_End as end_project, Projects.Name  from ProjectEmployes 
join Employes on ProjectEmployes.Employe_EmployeId = Employes.EmployeId join Projects on ProjectEmployes.Project_ProjectId = Projects.ProjectId
 where Employes.Name = 'Homer';

