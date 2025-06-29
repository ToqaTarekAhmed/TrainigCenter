namespace TrainigCenterApi.Models
{
    public class CoursePriceHistory : BaseEntity
    {
        public int TrainerCourseId { get; set; }
        public TrainerCourse TrainerCourse { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool HasOffer { get; set; }
        public decimal? DiscountPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Notes { get; set; }
    }
}