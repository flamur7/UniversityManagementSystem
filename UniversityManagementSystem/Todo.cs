using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Models;

namespace TodoList
{
    public static class Todo
    {
        public static List<TodoItem> List { get; set; } = new List<TodoItem>();
    }
}
