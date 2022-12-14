using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Cost { get; set; }
        public decimal Size { get; set; }
        public DateTime EndOfDate { get; set; }
        public DateTime ProduceOfDate { get; set; }
        public bool Status { get; set; }
    }
}
