using System.Linq.Expressions;
namespace LadysmithProperties.Data
{
    public interface IRepositoryBase<T>
    {
        T GetById(int id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void create(T entity);
        void Update(T entity);
        void delete(T entity);

    }
}
