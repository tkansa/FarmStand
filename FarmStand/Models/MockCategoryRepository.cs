using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> ICategoryRepository.AllCategories => 
            new List<Category> { 
                new Category{ CategoryId=1, CategoryName="Fruit", CategoryDescription="Sweet Fruits"},
                new Category{ CategoryId=2, CategoryName="Root Vegetables", CategoryDescription="Vegetables "},
                new Category{ CategoryId=3, CategoryName="Seeded Vegetables", CategoryDescription="Savory Fruits"},
                new Category{ CategoryId=4, CategoryName="Root Vegetables", CategoryDescription="Underground Produce"},
                new Category{ CategoryId=5, CategoryName="Mushrooms", CategoryDescription="Fungi"},
                new Category{ CategoryId=6, CategoryName="Herbs", CategoryDescription="Aromatic Leaves"}
            };

        
            
    }
}
