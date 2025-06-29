using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class CourseRegistartionRepo : GenericRepo<CourseRegistration>,ICourseRegistartion
    {
        public CourseRegistartionRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
