using FarmStand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.ViewModels
{
    public class ProduceListViewModel
    {
        public IEnumerable<Produce> Produce { get; set; }

        public string TableName { get; set; }
    }
}
