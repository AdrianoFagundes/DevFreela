using DevFreela.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project> 
            { 
                new Project("Project 1 ASPNET.CORE", "Description Project 1", 1, 1, 100000),
                new Project("Project 2 ASPNET.CORE", "Description Project 2", 1, 1, 200000),
                new Project("Project 3 ASPNET.CORE", "Description Project 3", 1, 1, 300000)
            };

            Users = new List<User>
            {
                new User("Joao", "adriano@teste.com.br",new DateTime(1990,1,1)),
                new User("Pedro", "pedro@teste.com.br",new DateTime(1990,1,1)),
                new User("Marcos", "marcos@teste.com.br",new DateTime(1990,1,1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
