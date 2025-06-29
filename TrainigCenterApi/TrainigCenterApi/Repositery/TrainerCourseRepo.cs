using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class TrainerCourseRepo : GenericRepo<TrainerCourse>, ITrainerCourse
    {
        public TrainerCourseRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
