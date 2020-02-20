using System.Collections.Generic;
using caseStudy.Infrastructure;
using caseStudy.Model;
using Microsoft.AspNetCore.Mvc;


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
