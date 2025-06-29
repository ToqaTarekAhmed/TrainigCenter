namespace TrainigCenterApi.DTOs
{
    public class CreateFeedbackDto
    {
        public int CourseRegistrationId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
