using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
  public class UserRepository : GenericRepository<User>, IUserRepository
  {
    public UserRepository(HealthCheckDatabaseContext dbContext) : base(dbContext)
    {
    }
  }
}
