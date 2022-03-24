using Microsoft.AspNetCore.Mvc;

namespace FeedbackToolDissertation.Data
{
    public class BaseController : ControllerBase
    {
        protected FeedbackToolDissertationContext DbContext { get; set; }
        public BaseController(FeedbackToolDissertationContext dbcontext)
        {
            DbContext = dbcontext;
        }
    }
}
