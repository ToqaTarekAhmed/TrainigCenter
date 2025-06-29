using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainigCenterApi.Interface;

using TrainigCenterApi.Models;

public class GenericRepo<T> : IGeneric<T> where T : BaseEntity
{
    private readonly TrainingCenterDbContext _context;

    public GenericRepo(TrainingCenterDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>()
            .Where(e => !e.IsDeleted && e.IsActive)
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllIncludingDeleted()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        entity.CreateDate = DateTime.Now;
        entity.IsActive = true;
        entity.IsDeleted = false;

        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        entity.UpdateDate = DateTime.Now;
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task SoftDeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null) return;

        entity.IsDeleted = true;
        entity.IsActive = false;
        entity.DeleteTime = DateTime.Now;

        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
