namespace TrainigCenterApi.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
       

        public ICollection<TrainerCourse> TrainerCourses { get; set; }
    }
}