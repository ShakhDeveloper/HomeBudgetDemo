using HomeBudgetDemo.Data;
using HomeBudgetDemo.Services.Interfaces;
using HomeBudgetDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Repositories
{
    public class UserRepository : IUserInterface
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ViewUser AddUser(ViewUser user)
        {
            _dbContext.viewUsers.Add(user);
            _dbContext.SaveChanges();

            return user;
        }

        public void DeleteUser(Guid id)
        {
            _dbContext.viewUsers.Remove(_dbContext.viewUsers.FirstOrDefault(p => p.Id == id));
        }

        public ViewUser GetById(Guid id)
        {
            return _dbContext.viewUsers.FirstOrDefault(p => p.Id == id);
        }

        public List<ViewUser> GetUsers()
        {
            return _dbContext.viewUsers.ToList();
        }

        public ViewUser UpdateUser(ViewUser user)
        {
            _dbContext.viewUsers.Update(user);
            _dbContext.SaveChanges();

            return user;
        }
    }
}
