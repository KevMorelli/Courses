using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class BestByCountryDto
    {
        public string Country { get; set; }
        public string Product { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
    }
}
