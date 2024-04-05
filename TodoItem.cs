using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
  internal class TodoItem
  {
    public static int id;
    public string title;
    public string description;
    public string dueDate;
    public string priority;
    public string status;

    public TodoItem(string title, string description, string dueDate, string priority, string status)
    {
      this.title = title;
      this.description = description;
      this.dueDate = dueDate;
      this.priority = priority;
      this.status = status;
      id += 1;
    }
  }
}
