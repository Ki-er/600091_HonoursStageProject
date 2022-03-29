using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;


namespace FeedbackToolDissertation.Data
{
    public class ACWService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public ACWService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Acw>> GetAcwsAsync(string currentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Acw.Where(x => x.UserName == currentUser).AsNoTracking().ToListAsync();
        }

        public Task<Acw> CreateACWAsync(Acw acw)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Acw.Add(acw);
            ctx.SaveChanges();

            return Task.FromResult(acw);
        }
    }
}
