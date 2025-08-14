public interface IRepository<T>
{
    int Create(T entity);
    int Delete(T entity);
    T Read(int id);
    List<T> SelectAll();
}