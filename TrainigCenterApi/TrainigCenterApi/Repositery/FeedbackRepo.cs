using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class FeedbackRepo : GenericRepo<Feedback>,IFeedBack
    {
        public FeedbackRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
