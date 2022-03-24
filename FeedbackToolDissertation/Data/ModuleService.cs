using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackToolDissertation.Data
{
    public class ModuleService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public ModuleService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Modules>> GetModulesAsync(string strCurrentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Modules.Where(x => x.UserName == strCurrentUser).AsNoTracking().ToListAsync();
        }

        public Task<Modules> CreateModulesAsync(Modules objModule)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Modules.Add(objModule);
            ctx.SaveChanges();

            return Task.FromResult(objModule);
        }
    }
}
