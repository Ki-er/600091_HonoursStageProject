using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class SectionService
    {
        private readonly FeedbacktooldissertationContext _context;

        public SectionService(FeedbacktooldissertationContext context)
        {
            _context = context;
        }

        public async Task<List<Sections>> GetSectionsAsync(string strCurrentUser)
        {
            return
            await _context.Sections
            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }

        public Task<Sections> CreateSectionsAsync(Sections sections)
        {
            _context.Sections.Add(sections);
            _context.SaveChanges();
            return Task.FromResult(sections);
        }


    }
}
