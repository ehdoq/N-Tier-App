using System.Linq.Expressions;

namespace NLayerApp.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T>? GetAll();
        Task<T>? GetByIdAsync(int? id);
        Task? AddAsync(T? entity);
        Task? AddRangeAsync(IEnumerable<T>? entities);
        //Task<IEnumerable<T>>? AddRangeAsync(IEnumerable<T>? entities);
        void Update(T? entity);
        void Remove(T? entity);
        void RemoveRange(IEnumerable<T>? entities);

        //Repository.Where(x => x.Id > 5)
        //Expression = metod içinde "x => x.Id > 5" ifadesini yazmama izin verir.
        //T = x => x.Id > 5, bool = true or false(var ya da yok)
        IQueryable<T>? Where(Expression<Func<T, bool>>? expression);
        Task<bool>? AnyAsync(Expression<Func<T, bool>>? expression);
    }
}
