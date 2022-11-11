

namespace DAB_Assignment2.Controller
{
    public interface IController<T>
    {
        T? Get(long id);
        List<T> GetAll();
        bool Add(T ent);
    }
    
}
