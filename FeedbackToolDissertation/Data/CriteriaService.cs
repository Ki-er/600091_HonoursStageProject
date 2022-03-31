using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;


namespace FeedbackToolDissertation.Data
{
    public class CriteriaService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public CriteriaService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Criteria>> GetCriteriasAsync(string currentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Criteria.Where(x => x.UserName == currentUser).AsNoTracking().ToListAsync();
        }

        public Task<Criteria> CreateCriteriaAsync(Criteria criteria)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Criteria.Add(criteria);
            ctx.SaveChanges();

            return Task.FromResult(criteria);
        }

        public Task<bool> DeleteCriteriaAsync(Criteria criterion)
        {
            using var ctx = _dbContext.CreateDbContext();
            var criteriaToBeDeleted = ctx.Criteria.Where(x => x.Criteria1 == criterion.Criteria1).FirstOrDefault();
            if (criteriaToBeDeleted != null)
            {
                ctx.Criteria.Remove(criteriaToBeDeleted);
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
