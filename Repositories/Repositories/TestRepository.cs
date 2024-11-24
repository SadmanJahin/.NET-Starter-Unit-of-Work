using AutoRegister;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories.DataAccess;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    [Register(ServiceLifetime.Scoped)]
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        private readonly DatabaseContext _databaseContext;
        public TestRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
