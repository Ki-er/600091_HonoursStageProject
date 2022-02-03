using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class ACWService
    {
        private readonly FeedbacktooldissertationContext _context;

        public ACWService(FeedbacktooldissertationContext context)
        {
            _context = context;
        }

        public async Task<List<Acw>> GetAcwsAsync(string strCurrentUser)
        {
            return
            await _context.Acw
            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }




    }
}