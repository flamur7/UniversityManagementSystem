using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoList;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class ToDoItemsController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["completed"] = Todo.List.Where(x => x.Completed == true).ToList();
            ViewData["todo"] = Todo.List.Where(x => x.Completed == false).ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                TodoItem last = Todo.List.LastOrDefault();
                if (last == null)
                {
                    item.Id = 1;
                }
                else
                {
                    item.Id = last.Id + 1;
                }
                Todo.List.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            TodoItem item = Todo.List.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                return View(item);
            }
            return RedirectToAction("Index");
        }

        [HttpPost("{id}")]
        public IActionResult Edit(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                TodoItem existig = Todo.List.Where(x => x.Id == item.Id).FirstOrDefault();
                if (existig != null)
                {
                    existig.Name = item.Name;
                    existig.Comment = item.Comment;
                    existig.Completed = item.Completed;
                }
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet("{id}")]
        public IActionResult Toggle(int id)
        {
            TodoItem item = Todo.List.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                item.Completed = !item.Completed;
            }
            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            Todo.List.RemoveAll(x => x.Id == id);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        public IActionResult Confirm(int id)
        {
            TodoItem item = Todo.List.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                return View(item);
            }
            return RedirectToAction("Index");
        }
    }
}
