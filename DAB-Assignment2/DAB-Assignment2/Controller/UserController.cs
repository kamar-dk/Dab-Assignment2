using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB_Assignment2.Controller;
using DAB_Assignment2.Data;
using DAB_Assignment2.Model;

namespace DAB_Assignment2.Controller
{
    public class UserController : IController<User>
    {
        private Context _context;

        public UserController(Context context)
        {
            _context = context;
        }

        public bool Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User? Get(long id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

    }
}
