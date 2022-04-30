using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class MockProduceRepository : IProduceRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Produce> AllProduce => 
            new List<Produce> { 
                new Produce{ ProduceId=1, Name="Strawberries", Price=4.99m, IsProduceOfTheWeek=false, Category=categoryRepository.AllCategories.ToList()[0], CategoryId=1, ImageUrl="" },
                new Produce{ ProduceId=2, Name="Onions", Price=1.99m, IsProduceOfTheWeek=false, Category=categoryRepository.AllCategories.ToList()[1], CategoryId=2, ImageUrl="" },
                new Produce{ ProduceId=3, Name="Cucumbers", Price=3.99m, IsProduceOfTheWeek=true, Category=categoryRepository.AllCategories.ToList()[2], CategoryId=3, ImageUrl="" }
            };

        public IEnumerable<Produce> ProduceOfTheWeek { get; }

        public Produce GetProduceById(int produceId)
        {
            return AllProduce.FirstOrDefault(p => p.ProduceId == produceId);
        }
    }
}
