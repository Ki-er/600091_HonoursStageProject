using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class ModuleService
    {
        private readonly FeedbacktooldissertationContext _context;

        public ModuleService(FeedbacktooldissertationContext context)
        {
            _context = context;
        }

        public async Task<List<Modules>> GetModulesAsync(string strCurrentUser)
        {
            // Get Weather Forecasts
            return
            await _context.Modules
            // Only get entries for the current logged in user
            .Where(x => x.UserName == strCurrentUser)
            // Use AsNoTracking to disable EF change tracking
            // Use ToListAsync to avoid blocking a thread
            .AsNoTracking().ToListAsync();
        }




    }
}
