using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using caseStudy.Infrastructure;
using caseStudy.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
