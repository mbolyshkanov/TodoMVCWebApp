using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoMVCWebApp.DAL
{
    public class TodoRepository : IRepository<Todo>
    {
        private TodoEntitiesContainer db = new TodoEntitiesContainer();

        IQueryable<Todo> IRepository<Todo>.FindAll()
        {
            return db.Todoes;
        }

        Todo IRepository<Todo>.Get(int id)
        {
            return db.Todoes.FirstOrDefault(c => c.Id == id);
        }

        void IRepository<Todo>.Save()
        {
            db.SaveChanges();
        }

        Todo IRepository<Todo>.Add(Todo todo)
        {
            db.Todoes.Add(todo);
            return todo;
        }

        void IRepository<Todo>.Delete(Todo todo)
        {
            db.Todoes.Remove(todo);
        }
    }
}