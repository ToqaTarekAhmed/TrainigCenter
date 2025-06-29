namespace TrainigCenterApi.Interface
{

    public interface IGeneric<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();              // يرجع العناصر النشطة فقط
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task SoftDeleteAsync(int id);                    // حذف منطقي
        Task<IEnumerable<T>> GetAllIncludingDeleted();   // يرجع كل العناصر بما فيها المحذوفة
    }

}