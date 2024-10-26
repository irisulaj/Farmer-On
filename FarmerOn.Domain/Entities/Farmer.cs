using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerOn.Domain.Entities
{
    public class Farmer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public required string Description { get; set; }


    }
}
