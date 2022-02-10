using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class CriteriaService
    {
        private readonly FeedbacktooldissertationContext _context;

        public CriteriaService(FeedbacktooldissertationContext context)
        {
            _context = context;
        }

        public async Task<List<Criteria>> GetCriteriasAsync(string strCurrentUser)
        {
            return
            await _context.Criteria
            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }

        public Task<Criteria> CreateCriteriaAsync(Criteria criteria)
        {
            _context.Criteria.Add(criteria);
            _context.SaveChanges();
            return Task.FromResult(criteria);
        }


    }
}
