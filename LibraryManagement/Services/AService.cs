public abstract class AService<T>
{
    public IRepository<T> repository;
    public List<T> entityList;

    public abstract bool CheckDuplication(T entity);
    public abstract bool CheckInputForm(T entity);

    public AService(IRepository<T> repository)
    {
        this.repository = repository;
        this.entityList = repository.SelectAll();
    }
    public virtual bool Register(T entity)
    {
        if(repository.Create(entity) > 0)
        {
            entityList = repository.SelectAll();
            return true;
        }
        return false;
    }

    public virtual bool Delete(T entity)
    {
        if(repository.Delete(entity) > 0)
        {
            entityList = repository.SelectAll();
            return true;
        }
        return false;
    }
    
    public virtual List<T> EntityAll()
    {
        return entityList;
    }

}
