using HomeBudgetDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Interfaces
{
   public interface IRegUserInterface
    {
        List<RegViewModel> GetRegViewModels();
        RegViewModel GetById(Guid id);
        RegViewModel AddRegModel(RegViewModel regViewModel);
        RegViewModel UpdateRegModel(RegViewModel regViewModel);
        void DeleteRegModel(Guid id);

    }
}
