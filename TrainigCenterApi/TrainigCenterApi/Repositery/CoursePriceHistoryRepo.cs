using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class CoursePriceHistoryRepo : GenericRepo<CoursePriceHistory>, ICoursePriceHistory
    {
        public CoursePriceHistoryRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }

    
}
