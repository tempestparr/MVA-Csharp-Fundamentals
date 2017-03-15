﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Todo> todos = new List<Todo>()
            {
                   new Todo { Description = "Task 1", EstimatedHours = 8, Status = Status.Completed },
                   new Todo { Description = "Task 2", EstimatedHours = 3, Status = Status.OnHold },
                   new Todo { Description = "Task 3", EstimatedHours = 4, Status = Status.InProgess },
                   new Todo { Description = "Task 4", EstimatedHours = 8, Status = Status.Completed },
                   new Todo { Description = "Task 5", EstimatedHours = 4, Status = Status.Deleted },
                   new Todo { Description = "Task 6", EstimatedHours = 5, Status = Status.InProgess },
                   new Todo { Description = "Task 7", EstimatedHours = 6, Status = Status.NotStarted },
                   new Todo { Description = "Task 8", EstimatedHours = 2, Status = Status.NotStarted },
                   new Todo { Description = "Task 9", EstimatedHours = 1, Status = Status.InProgess },
                   new Todo { Description = "Task 10", EstimatedHours = 9, Status = Status.Completed },
                   new Todo { Description = "Task 11", EstimatedHours = 10, Status = Status.Completed },
                   new Todo { Description = "Task 12", EstimatedHours = 3, Status = Status.Deleted },
                   new Todo { Description = "Task 13", EstimatedHours = 4, Status = Status.OnHold },
                   new Todo { Description = "Task 14", EstimatedHours = 5, Status = Status.Completed },
            };

            Console.ForegroundColor = ConsoleColor.DarkMagenta;


            PrintAssessment(todos);
            Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProgess:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            
            }
        }

    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgess,
        OnHold,
        Completed,
        Deleted
    }


}
