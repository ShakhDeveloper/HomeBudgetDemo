using HomeBudgetDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Interfaces
{
    public interface IUserInterface
    {
        List<ViewUser> GetUsers();
        ViewUser GetById(Guid id);
        ViewUser AddUser(ViewUser user);
        ViewUser UpdateUser(ViewUser user);
        void DeleteUser(Guid id);
    }
}
