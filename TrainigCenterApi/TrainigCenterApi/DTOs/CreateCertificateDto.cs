namespace TrainigCenterApi.DTOs
{
    public class CreateCertificateDto
    {
        public int CourseRegistrationId { get; set; }
        public DateTime IssueDate { get; set; }
        public string CertificateUrl { get; set; }
    }

}
