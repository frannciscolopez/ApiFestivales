using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caseStudy.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace caseStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CartelController : ControllerBase
    {
        public FileRepository fr = new FileRepository();

        [HttpGet("{nombre_festival}")]
        public Festival Get(string nombre_festival)
        {
            return fr.GetFestivalPorNombre(nombre_festival);

        }
    }
}
