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
    public class StockController : Controller
    {
        public FileRepository fr = new FileRepository();
        [HttpGet]
        public List<Stock> Get()
        {
            List<Stock> list = fr.GetStock();
            return list;



        }
    }
}
