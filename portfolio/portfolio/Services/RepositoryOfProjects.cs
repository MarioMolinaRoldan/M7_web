using portfolio.Models;

namespace portfolio.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>()
            {
                new ClassProjects {
                    Title = "ASP.net",
                    Description = "WEB realizado en ASP.net",
                    Link = "",
                    ImageURL = "/images/dotnet.png"
                  },
                new ClassProjects {
                    Title = "JavaScript",
                    Description = "Proyecto JavaScript",
                    Link = "",
                    ImageURL = "/images/rosa.png"
                  },
                new ClassProjects {
                    Title = "Html5",
                    Description = "Proyecto Html5",
                    Link = "",
                    ImageURL = "/images/html.png"
                  }
            };
        }

    }
    }
