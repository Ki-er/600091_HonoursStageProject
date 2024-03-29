﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackToolDissertation.Data.FeedbackToolDissertation;
using Microsoft.EntityFrameworkCore;


namespace FeedbackToolDissertation.Data
{
    public class FeedbackService
    {
        private IDbContextFactory<FeedbacktooldissertationContext> _dbContext;

        public FeedbackService(IDbContextFactory<FeedbacktooldissertationContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Feedback>> GetFeedbacksAsync(string currentUser)
        {
            using var context = _dbContext.CreateDbContext();
            return await context.Feedback.Where(x => x.UserName == currentUser).AsNoTracking().ToListAsync();
        }


        public Task<Feedback> CreateFeedbackAsync(Feedback feedback)
        {
            using var context = _dbContext.CreateDbContext();
            context.Feedback.Add(feedback);
            context.SaveChanges();

            return Task.FromResult(feedback);
        }

        public Task<bool> DeleteFeedbackAsync(Feedback feedback)
        {
            using var ctx = _dbContext.CreateDbContext();
            var feeddbackToBeDeleted = ctx.Feedback.Where(x => x.Feedback1 == feedback.Feedback1).FirstOrDefault();
            if (feeddbackToBeDeleted != null)
            {
                ctx.Feedback.Remove(feeddbackToBeDeleted);
                ctx.SaveChanges();
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }

        }
    }
}
