using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMVCWebApp.DAL;
using TodoMVCWebApp.ViewModels;

namespace TodoMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Todo> repository = null;

        public HomeController()
        {
            repository = new TodoRepository();
        }

        [HttpGet]
        public ActionResult Get()
        {
            var todos = repository.FindAll();
            var list = new List<TodoViewModel>();
            foreach (var t in todos)
                list.Add(new TodoViewModel(t));

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Post(TodoViewModel newTodo)
        {
            var todo = new Todo();
            UpdateModel(todo, new[] { "Text", "Done", "Order" });
            ValidateModel(todo);
            repository.Add(todo);
            repository.Save();
            return Json(new TodoViewModel(todo));
        }

        [HttpPut]
        public ActionResult Put(int id, TodoViewModel newTodo)
        {
            var todo = repository.Get(id);
            UpdateModel(todo, new[] { "Text", "Done", "Order" });
            ValidateModel(todo);
            repository.Save();
            return Json(new TodoViewModel(todo));
        }

        [HttpDelete]
        public ActionResult Delete(int id )
        {
            var todo = repository.Get(id);
            if (todo != null)
            {
                repository.Delete(todo);
                repository.Save();
            }
            return Json(new { });
        }

        public ActionResult Index()
        {
            var todos = repository.FindAll();
            var list = new List<TodoViewModel>();
            foreach (var t in todos)
                list.Add(new TodoViewModel(t));

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
