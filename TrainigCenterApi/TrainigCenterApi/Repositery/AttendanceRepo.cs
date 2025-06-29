using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

namespace TrainigCenterApi.Repositery
{
    public class AttendanceRepo : GenericRepo<Attendance>,IAttendance
    {
        public AttendanceRepo(TrainingCenterDbContext context) : base(context)
        {
        }
    }
}
