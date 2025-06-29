namespace TrainigCenterApi.Models
{
    public class TrainerCourse : BaseEntity
    {
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        
        public ICollection<CoursePriceHistory> CoursePriceHistories { get; set; }
        public ICollection<CourseRegistration> CourseRegistrations { get; set; }
    }
}