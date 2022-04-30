using System.Collections.Generic;

namespace FarmStand.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Produce> ProduceList { get; set; }
    }
}