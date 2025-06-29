namespace TrainigCenterApi.Models
{
    public class CourseRegistration : BaseEntity
    {
        public int CoursePriceHistoryId { get; set; }
        public CoursePriceHistory CoursePriceHistory { get; set; }
        public int TrainerCourseId { get; set; }
        public TrainerCourse TrainerCourse { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
       
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
       
    }
}