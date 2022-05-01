using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public class ProduceRepository: IProduceRepository
    {
        private readonly AppDbContext appDbContext;

        public ProduceRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Produce> AllProduce
        {
            get
            {
                return appDbContext.Produce.Include(c => c.Category);
            }
        }

        public IEnumerable<Produce> ProduceOfTheWeek
        {
            get
            {
                return appDbContext.Produce.Include(c => c.Category).Where(p => p.IsProduceOfTheWeek);
            }
        }
        public Produce GetProduceById(int produceId)
        {
           return appDbContext.Produce.FirstOrDefault(p => p.ProduceId == produceId);
        }
    }
}
