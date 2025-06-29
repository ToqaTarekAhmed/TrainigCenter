using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class TraineeRepo : GenericRepo<Trainee>,ITrainee
    {
        public TraineeRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
