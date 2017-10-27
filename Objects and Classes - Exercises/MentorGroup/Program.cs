using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                string[] arguments = input.Split(' ');

                bool existingStudent = false;

                string studentName = arguments[0];

                foreach (Student student1 in students)
                {
                    if (student1.Name == studentName)
                    {
                        existingStudent = true;

                        if (arguments.Length > 1)
                        {
                            string[] dates = arguments[1].Split(',');

                            foreach (string date in dates)
                            {
                                student1.Attendances.Add(DateTime.ParseExact(date, "dd/MM/yyyy",
                                    CultureInfo.InvariantCulture));
                            }
                        }
                    }
                }

                if (!existingStudent)
                {
                    Student student = new Student();

                    student.Attendances = new List<DateTime>();

                    student.Comments = new List<string>();

                    student.Name = studentName;

                    if (arguments.Length > 1)
                    {
                        string[] dates = arguments[1].Split(',');

                        foreach (string date in dates)
                        {
                            student.Attendances.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        }
                    }

                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                string[] arguments = input.Split('-');

                string studentName = arguments[0];

                if (arguments.Length > 1)
                {
                    string comment = arguments[1];

                    foreach (Student student in students)
                    {
                        if (student.Name == studentName)
                        {
                            student.Comments.Add(comment);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Student student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);

                Console.WriteLine("Comments:");

                foreach (string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (DateTime attendance in student.Attendances.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {attendance.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendances { get; set; }
    }
}
