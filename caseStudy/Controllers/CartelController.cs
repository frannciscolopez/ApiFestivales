using caseStudy.Infrastructure;
using Microsoft.AspNetCore.Mvc;


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
