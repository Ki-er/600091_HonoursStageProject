using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FeedbackToolDissertation.Data
{
    public class ModuleService
    {
        public async Task<List<Modules>> GetModulesAsync(string strCurrentUser)
        {
            using (var ctx = new FeedbacktooldissertationContext())
            {
                return await ctx.Modules.Where(x => x.UserName == strCurrentUser).AsNoTracking().ToListAsync();
            }

        }

        public Task<Modules> CreateModulesAsync(Modules objModule)
        {
            using (var ctx = new FeedbacktooldissertationContext())
            {
                ctx.Modules.Add(objModule);
                ctx.SaveChanges();
                return Task.FromResult(objModule);
            }


        }












    }
}
