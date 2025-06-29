
namespace TrainigCenterApi.Models
{
    public class Attendance : BaseEntity
    {
        public int CourseRegistrationId { get; set; }
        public CourseRegistration CourseRegistration { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}