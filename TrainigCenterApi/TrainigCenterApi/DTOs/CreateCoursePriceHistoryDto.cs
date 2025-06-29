namespace TrainigCenterApi.DTOs
{
    public class CreateCoursePriceHistoryDto
    {
        public int TrainerCourseId { get; set; }

        public decimal OriginalPrice { get; set; }

        public bool HasOffer { get; set; }

        public decimal? DiscountPrice { get; set; } // مطلوب فقط لو HasOffer = true

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? Notes { get; set; }

    }
}
