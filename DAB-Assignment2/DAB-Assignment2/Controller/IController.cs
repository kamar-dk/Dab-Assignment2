using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.Controller
{
    public interface IController<T>
    {
        T? Get(long id);
        List<T> GetAll();
        bool Add(T ent);
        //bool Delete(long id);

    }
    
}
