namespace TrainigCenterApi.Models
{
    public class Trainer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<TrainerCourse> TrainerCourses { get; set; }
    }
}