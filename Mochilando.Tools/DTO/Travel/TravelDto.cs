using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mochilando.Tools.DTO.Travel
{
    public class TravelDto
    {
        public Guid UID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }
    }
}
