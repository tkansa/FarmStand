using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return appDbContext.Categories;
            }
        }
    }
}
