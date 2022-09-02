using System.Linq.Expressions;

namespace NLayerApp.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>>? GetAllAsync();
        Task<T>? GetByIdAsync(int? id);
        Task<T>? AddAsync(T? entity);
        Task<IEnumerable<T>>? AddRangeAsync(IEnumerable<T>? entities);
        Task? UpdateAsync(T? entity);
        Task? RemoveAsync(T? entity);
        Task? RemoveRangeAsync(IEnumerable<T>? entities);
        IQueryable<T>? Where(Expression<Func<T, bool>> expression);
        Task<bool>? AnyAsync(Expression<Func<T, bool>> expression);
    }
}
