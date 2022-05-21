
using HomeBudgetDemo.Data;
using HomeBudgetDemo.Models;
using HomeBudgetDemo.Services.Interfaces;
using HomeBudgetDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICostOrIncomeInterface costOrIncome;
        private readonly ICategoryIncomeInterface incomeInterface;
        private readonly ICategoryCostInterface _costInterface;

        public HomeController(ICostOrIncomeInterface costOrIncome,
                                ICategoryIncomeInterface incomeInterface, ICategoryCostInterface costInterface)
        {
            this.costOrIncome = costOrIncome;
            this.incomeInterface = incomeInterface;
            _costInterface = costInterface;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ViewIncome()
        {
            var list = await costOrIncome.GetCostOrIncomes();
            List<ViewIncomeViewModel> listOfViewModels = new List<ViewIncomeViewModel>();
            foreach (var v in list.Where(c => c.type == CostOrIncomeType.Доход).ToList())
            {
                var category = await incomeInterface.GetCategoryIncome(v.CategoryId);
                ViewIncomeViewModel viewModel = new ViewIncomeViewModel()
                {
                    Id = v.Id,
                    Date = v.Date,
                    type = v.type,
                    Sum = v.Sum,
                    Comment = v.Comment,
                    CategoryName = category.Name
                };
                listOfViewModels.Add(viewModel);
            };
            return View(listOfViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> ViewCosts()
        {
            var list = await costOrIncome.GetCostOrIncomes();
            List<ViewIncomeViewModel> listOfViewModels = new List<ViewIncomeViewModel>();
            foreach (var v in list.Where(c => c.type == CostOrIncomeType.Расход).ToList())
            {
                var category = await _costInterface.GetCategoryCost(v.CategoryId);
                ViewIncomeViewModel viewModel = new ViewIncomeViewModel()
                {
                    Id = v.Id,
                    Date = v.Date,
                    type = v.type,
                    Sum = v.Sum,
                    Comment = v.Comment,
                    CategoryName = category.Name
                };
                listOfViewModels.Add(viewModel);
            };
            return View(listOfViewModels);
        }
       
        [HttpGet]
        public IActionResult AddCost()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCost(CostOrIncome cost)
        {
            cost.type = CostOrIncomeType.Расход;
            await costOrIncome.AddCostOrIncome(cost);
            return RedirectToAction("ViewCosts");
        }
        [HttpGet]
        public IActionResult AddIncome()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddIncome(CostOrIncome income)
        {
            income.type = CostOrIncomeType.Доход;
            await costOrIncome.AddCostOrIncome(income);


            return RedirectToAction("ViewIncome");
        }

        public IActionResult DeleteIn(int id)
        {
            costOrIncome.DeleteCostOrIncome(id);

            return RedirectToAction("ViewIncome");
        }
        public IActionResult DeleteCos(int id)
        {
            costOrIncome.DeleteCostOrIncome(id);

            return RedirectToAction("ViewCosts");
        }


        //for cost
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var list = await costOrIncome.GetCostOrIncome(id);

            return View((ViewCostModel)list);

        }

        //for cost
        [HttpPost]
        public async Task<IActionResult> Edit(ViewCostModel viewModel)
        {
            CostOrIncome costOr = new CostOrIncome()
            {
                Id = viewModel.Id,
                Date = viewModel.Date,
                type = viewModel.type,
                Sum = viewModel.Sum,
                Comment = viewModel.Comment,
                CategoryId = viewModel.CategoryId
            };

            costOr = await costOrIncome.UpdateCostOrIncome(costOr);
            return RedirectToAction("ViewCosts");
        }


        //for income
        [HttpGet]
        public async Task<IActionResult> EditIncome(int id)
        {
            var list = await costOrIncome.GetCostOrIncome(id);

            return View((ViewCostModel)list);

        }

        //for income
        [HttpPost]
        public async Task<IActionResult> EditIncome(ViewCostModel viewModel)
        {
            CostOrIncome costOr = new CostOrIncome()
            {
                Id = viewModel.Id,
                Date = viewModel.Date,
                type = CostOrIncomeType.Доход,
                Sum = viewModel.Sum,
                Comment = viewModel.Comment,
                CategoryId = viewModel.CategoryId
            };

            costOr = await costOrIncome.UpdateCostOrIncome(costOr);
            return RedirectToAction("ViewIncome");
        }
    }
}

