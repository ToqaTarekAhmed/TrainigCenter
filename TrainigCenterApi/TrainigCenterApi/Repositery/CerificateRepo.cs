using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class CerificateRepo : GenericRepo<Certificate>,ICertificate
    {
        public CerificateRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
