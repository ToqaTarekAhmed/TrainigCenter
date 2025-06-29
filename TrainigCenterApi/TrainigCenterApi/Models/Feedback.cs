namespace TrainigCenterApi.Models
{
    public class Feedback : BaseEntity
    {
        public int CourseRegistrationId { get; set; }
        public CourseRegistration CourseRegistration { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}