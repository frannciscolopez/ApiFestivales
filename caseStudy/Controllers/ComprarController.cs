using caseStudy.Infrastructure;
using caseStudy.Model;
using Microsoft.AspNetCore.Mvc;



namespace caseStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ComprarController : Controller
    {
        public FileRepository fr = new FileRepository();
        [HttpPost]
        public CompraResponse Post([FromBody]CompraRequest request)
        {
            return fr.GetResponse(request);
        }
    }
}
