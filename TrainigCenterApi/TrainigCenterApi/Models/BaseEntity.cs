public abstract class BaseEntity
{
    public int Id { get; set; }
    public int? CreateUserId { get; set; }
    public DateTime CreateDate { get; set; }
    public int? UpdateUserId { get; set; }
    public DateTime? UpdateDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeleteTime { get; set; }
}