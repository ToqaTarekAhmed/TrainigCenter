namespace TrainigCenterApi.DTOs
{
    public class CreateCourseVideoDto
    {
        public int CourseRegistrationId { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public int PeriodVedioMinutes { get; set; }

    }
}
