using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class CourseRepo : GenericRepo<Course>,ICourse
    {
        public CourseRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
