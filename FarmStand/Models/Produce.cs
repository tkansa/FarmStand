using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class Produce
    {
        public int ProduceId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool IsProduceOfTheWeek { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}
