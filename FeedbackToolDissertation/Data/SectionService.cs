using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class SectionService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public SectionService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Sections>> GetSectionsAsync(string strCurrentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Sections.Where(x => x.UserName == strCurrentUser).AsNoTracking().ToListAsync();
        }

        public Task<Sections> CreateSectionsAsync(Sections objSections)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Sections.Add(objSections);
            ctx.SaveChanges();

            return Task.FromResult(objSections);
        }


    }
}
