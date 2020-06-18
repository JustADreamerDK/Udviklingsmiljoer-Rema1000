using System.Collections.Generic;

namespace Rema1000.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
