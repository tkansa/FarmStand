using FarmStand.Models;
using FarmStand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmStand.Controllers
{
    public class ProduceController : Controller
    {
        private readonly IProduceRepository produceRepository;
        private readonly ICategoryRepository categoryRepository;
        public ProduceController(IProduceRepository produceRepository, ICategoryRepository categoryRepository)
        {
            this.produceRepository = produceRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ProduceListViewModel produceListViewModel = new ProduceListViewModel();
            produceListViewModel.Produce = produceRepository.AllProduce;
            produceListViewModel.TableName = "Farmer Marco's Table";
            return View(produceListViewModel);
        }
    }
}
