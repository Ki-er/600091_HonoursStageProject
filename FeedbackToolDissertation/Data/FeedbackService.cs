using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class FeedbackService
    {
        private readonly FeedbacktooldissertationContext _context;

        public FeedbackService(FeedbacktooldissertationContext context)
        {
            _context = context;
        }

        public async Task<List<Feedback>> GetFeedbacksAsync(string strCurrentUser)
        {
            return
            await _context.Feedback
            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }


        public Task<Feedback> CreateFeedbackAsync(Feedback feedback)
        {
            _context.Feedback.Add(feedback);
            _context.SaveChanges();
            return Task.FromResult(feedback);
        }



    }
}
