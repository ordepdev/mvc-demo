using FirstMVCApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class ProjectsController : Controller
    {
        [Log]
        [Route("projects/{title?}")]
        public ActionResult Projects(string title)
        {
            List<Project> model = projects;
            if (!string.IsNullOrEmpty(title)) 
                model = model.Where(p => p.Title.Equals(title)).ToList();
            return View(model);
        }

        static List<Project> projects = new List<Project>()
        {
            new Project { Id = 1, Title = "PROJ1" },
            new Project { Id = 2, Title = "PROJ2" },
            new Project { Id = 3, Title = "PROJ3" },
            new Project { Id = 4, Title = "PROJ4" }
        };
    }
}