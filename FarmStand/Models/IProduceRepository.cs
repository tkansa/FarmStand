using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Models
{
    public interface IProduceRepository
    {
        IEnumerable<Produce> AllProduce { get; }

        IEnumerable<Produce> ProduceOfTheWeek { get; }

        Produce GetProduceById(int produceId);

    }
}
