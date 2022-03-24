using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class FeedbackService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public FeedbackService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Feedback>> GetFeedbacksAsync(string strCurrentUser)
        {
            using var context = _dbContext.CreateDbContext();

            return await context.Feedback            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }


        public Task<Feedback> CreateFeedbackAsync(Feedback feedback)
        {
            using var context = _dbContext.CreateDbContext();
            context.Feedback.Add(feedback);
            context.SaveChanges();

            return Task.FromResult(feedback);
        }
    }
}
