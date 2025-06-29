using TrainigCenterApi.Interface;
using TrainigCenterApi.Models;


namespace TrainigCenterApi.Repositery
{
    public class TrainerRepo : GenericRepo<Trainer>,ITrainer
    {
        public TrainerRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
