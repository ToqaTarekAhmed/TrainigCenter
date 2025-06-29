using TrainigCenterApi.Interface;
using TrainigCenterApi.Repositery;

namespace TrainigCenterApi.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // 👇 هنا بتسجل كل الـ Services
            services.AddScoped(typeof(IGeneric<>), typeof(GenericRepo<>));
            services.AddScoped<ICourse, CourseRepo>();
            services.AddScoped<IAttendance, AttendanceRepo>();
            services.AddScoped<ICertificate, CerificateRepo>();
            services.AddScoped<ICourseRegistartion, CourseRegistartionRepo>();
            services.AddScoped<IFeedBack, FeedbackRepo>();
            services.AddScoped<ITrainee, TraineeRepo>();
            services.AddScoped<ITrainerCourse, TrainerCourseRepo>();
            services.AddScoped<ICoursePriceHistory, CoursePriceHistoryRepo>();
            
            services.AddScoped<ITrainer, TrainerRepo>();
            return services;
        }
    }
}
