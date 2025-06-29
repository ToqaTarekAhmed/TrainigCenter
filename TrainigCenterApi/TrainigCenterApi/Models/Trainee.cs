namespace TrainigCenterApi.Models
{
    public class Trainee : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<CourseRegistration> CourseRegistrations { get; set; }
    }
}