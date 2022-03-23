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
            return await _context.Modules.Where(x => x.UserName == strCurrentUser).AsNoTracking().ToListAsync();
        }

        public Task<Modules> CreateModulesAsync(Modules objModule)
        {
            _context.Modules.Add(objModule);
            _context.SaveChanges();
            return Task.FromResult(objModule);
        }

        public Task<bool> DeleteModulesAsync(Modules objModule)
        {
            var moduleToDelete = _context.Modules.Where(x => x.Id == objModule.Id).FirstOrDefault();
            if (moduleToDelete != null)
            {
                _context.Modules.Remove(moduleToDelete);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }











    }
}
