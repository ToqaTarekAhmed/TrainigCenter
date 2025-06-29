using Microsoft.EntityFrameworkCore;
using TrainigCenterApi.Models;
using TrainigCenterApi.Models;

public class TrainingCenterDbContext : DbContext
{
    public TrainingCenterDbContext(DbContextOptions<TrainingCenterDbContext> options)
        : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CoursePriceHistory> CoursePriceHistories { get; set; }
    public DbSet<CourseRegistration> CourseRegistrations { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<TrainerCourse> TrainerCourses { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<CoursePriceHistory>()
            .Property(p => p.OriginalPrice).HasPrecision(18, 2);
        modelBuilder.Entity<CoursePriceHistory>()
            .Property(p => p.DiscountPrice).HasPrecision(18, 2);

        
        // CourseRegistration ↔ CoursePriceHistory
        modelBuilder.Entity<CourseRegistration>()
            .HasOne(cr => cr.CoursePriceHistory)
            .WithMany()
            .HasForeignKey(cr => cr.CoursePriceHistoryId)
            .OnDelete(DeleteBehavior.Restrict);

       
        // TrainerCourse ↔ Course
        modelBuilder.Entity<TrainerCourse>()
            .HasOne(tc => tc.Course)
            .WithMany(c => c.TrainerCourses)
            .HasForeignKey(tc => tc.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}


