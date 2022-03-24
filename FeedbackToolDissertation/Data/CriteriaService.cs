using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class CriteriaService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public CriteriaService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Criteria>> GetCriteriasAsync(string strCurrentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Criteria.Where(x => x.UserName == strCurrentUser).AsNoTracking().ToListAsync();
        }

        public Task<Criteria> CreateCriteriaAsync(Criteria objCriteria)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Criteria.Add(objCriteria);
            ctx.SaveChanges();

            return Task.FromResult(objCriteria);
        }
    }
}
