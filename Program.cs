using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        DisplayMenu();
        string userInput = GetUserMenuInput();
        RenderMenuBasedOnUserInput(userInput);
      }
    }

    static void DisplayMenu()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Taskpulse\n");
      Console.WriteLine("This simple application allows you to manage your tasks right from the command line\n");
      Console.WriteLine("Instructions:\n");
      Console.WriteLine("- To add a new task, enter '1'.\n");
      Console.WriteLine("- To view your tasks, enter '2'.\n");
      Console.WriteLine("- To mark a task as completed, enter '3'.\n");
      Console.WriteLine("- To exit the application, enter '4'.\n\n");
      Console.WriteLine("Let's get started!\n");
    }
    static string GetUserMenuInput()
    {
      Console.Write("Choice: ");
      string userChoice = Console.ReadLine();
      return userChoice;
    }
    static void RenderMenuBasedOnUserInput(string userChoice)
    {
      Console.Clear();
      switch (userChoice)
      {
        case "1":
          CreateNewTask();
          break;
      }
    }
    static void CreateNewTask()
    {
      Console.Write("Enter number of tasks: ");
      int numberOfTasks = int.Parse(Console.ReadLine());
      Console.WriteLine("\n");
      TodoItem[] todoItems = new TodoItem[numberOfTasks];
      for (int i = 0; i < numberOfTasks; i++)
      {
        Console.WriteLine($"Task{i + 1}");
        Console.Write("Task title: ");
        string title = Console.ReadLine();
        Console.Write("Task description: ");
        string description = Console.ReadLine();
        Console.Write("Task due date: ");
        string dueDate = Console.ReadLine();
        Console.Write("Task priority: ");
        string priority = Console.ReadLine();
        Console.Write("Task status: ");
        string status = Console.ReadLine();
        Console.WriteLine("\n");
        TodoItem todoItem = new TodoItem(title, description, dueDate, priority, status);
        todoItems[i] = todoItem;
      }
    }
  }
}
