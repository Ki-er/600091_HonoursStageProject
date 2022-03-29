using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;

namespace FeedbackToolDissertation.Data
{
    public class ModuleService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public ModuleService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Modules>> GetModulesAsync(string currentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Modules.Where(x => x.UserName == currentUser).AsNoTracking().ToListAsync();
        }

        public Task<Modules> CreateModulesAsync(Modules module)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Modules.Add(module);
            ctx.SaveChanges();

            return Task.FromResult(module);
        }

        public Task<bool> DeleteModulesAsync(Modules module)
        {
            using var ctx = _dbContext.CreateDbContext();
            var moduleToBeDeleted = ctx.Modules.Where(x => x.ModuleName == module.ModuleName).FirstOrDefault();
            if (moduleToBeDeleted != null)
            {
                ctx.Modules.Remove(moduleToBeDeleted);
                ctx.SaveChanges();
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }

        }



    }
}
