using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;


namespace FeedbackToolDissertation.Data
{
    public class SectionService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public SectionService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Sections>> GetSectionsAsync(string currentUser)
        {
            using var ctx = _dbContext.CreateDbContext();
            return await ctx.Sections.Where(x => x.UserName == currentUser).AsNoTracking().ToListAsync();
        }

        public Task<Sections> CreateSectionsAsync(Sections sections)
        {
            using var ctx = _dbContext.CreateDbContext();
            ctx.Sections.Add(sections);
            ctx.SaveChanges();
            return Task.FromResult(sections);
        }


    }
}
