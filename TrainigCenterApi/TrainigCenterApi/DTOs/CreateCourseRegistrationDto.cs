namespace TrainigCenterApi.DTOs
{
    public class CreateCourseRegistrationDto
    {
        public int CoursePriceHistoryId { get; set; }
        
        public int TrainerCourseId { get; set; }
        public int TraineeId { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime? PaidDate { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

}
