using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int AmountOfProduct { get; set; }
        public Product Product { get; set; }
    }
}
