using System;
using System.Collections.Generic;
using static System.Console;

namespace _
{
    public class _
    {
        public static void Main()
        {
            Title = "DR";
            var taskList = new TaskList();
            taskList.a1();
            taskList.b1();
            ReadKey();
        }

    }
    public class A1
    {
        public string Day { get; set; }
        public string Tasks { get; set; }
        public A1(string day, string t1)
        {
            Day = day;
            Tasks = t1;
        }
        public A1(int a1, string day, string t1)
        {
            Day = day;
            Tasks = t1;
        }
    }
    public class TaskList : List<A1>
    {
        public void Add(string day, string t1)
        {
            Add(new A1(day, t1));
        }
        public void b1()
        {
            WriteLine();
            WriteLine("Day | Tasks");
            WriteLine();
            foreach (var t in this)
            {
                WriteLine("{1} | {2}", ToString(), t.Day, t.Tasks);
            }
        }
        public void a1()
        {
            string day = String.Empty;
            string t1 = String.Empty;

            Write("Enter Day : ");
            day = ReadLine().Trim();
            WriteLine("{0}\n", day);

            Write("Add Task : ");
            t1 = ReadLine();
            WriteLine("\"{0}\"", t1);
            Add(day, t1);
        }
    }
}