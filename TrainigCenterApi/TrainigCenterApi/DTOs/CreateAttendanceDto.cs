namespace TrainigCenterApi.DTOs
{
    public class CreateAttendanceDto
    {
        public int CourseRegistrationId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
