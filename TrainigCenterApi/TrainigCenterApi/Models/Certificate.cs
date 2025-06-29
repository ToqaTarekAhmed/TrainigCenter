namespace TrainigCenterApi.Models
{
    public class Certificate : BaseEntity
    {
        public int CourseRegistrationId { get; set; }
        public CourseRegistration CourseRegistration { get; set; }
        public DateTime IssueDate { get; set; }
        public string CertificateUrl { get; set; }
    }
}