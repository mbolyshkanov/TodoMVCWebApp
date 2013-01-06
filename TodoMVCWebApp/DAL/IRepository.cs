using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVCWebApp.DAL
{
    interface IRepository<T>
    {
        IQueryable<T> FindAll();
        T Get(int id);
        void Save();
        T Add(T t);
        void Delete(T t);
    }
}
