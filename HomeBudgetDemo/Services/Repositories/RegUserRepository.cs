using HomeBudgetDemo.Data;
using HomeBudgetDemo.Services.Interfaces;
using HomeBudgetDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Repositories
{
    public class RegUserRepository : IRegUserInterface
    {
        private readonly AppDbContext _dbContext;

        public RegUserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public RegViewModel AddRegModel(RegViewModel regViewModel)
        {
            _dbContext.regViewModels.Add(regViewModel);
            _dbContext.SaveChanges();

            return regViewModel;
        }

        public void DeleteRegModel(Guid id)
        {
            _dbContext.regViewModels.Remove(_dbContext.regViewModels.FirstOrDefault(p => p.Id == id));
        }

        public RegViewModel GetById(Guid id)
        {
           return _dbContext.regViewModels.FirstOrDefault(p => p.Id == id);
        }

        public List<RegViewModel> GetRegViewModels()
        {
            return _dbContext.regViewModels.ToList();
        }

        public RegViewModel UpdateRegModel(RegViewModel regViewModel)
        {
            _dbContext.regViewModels.Update(regViewModel);
            _dbContext.SaveChanges();

            return regViewModel;
        }
    }

}
