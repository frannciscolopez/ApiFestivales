using System;
namespace caseStudy.Model
{
    public class CompraResponse
    {
        public int CosteTotal { get; set; }
        public DateTime FechaCompra => DateTime.Now;
    }
}
