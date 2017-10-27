using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(' ');

                Student student = new Student();

                student.Grades = new List<double>();

                string name = inputArgs[0];

                student.Name = name;

                foreach (string grade in inputArgs.Skip(1))
                {
                    student.Grades.Add(double.Parse(grade));
                }

                students.Add(student);
            }

            foreach (Student student in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                if (student.Average >= 5)
                {
                    Console.WriteLine($"{student.Name} -> {student.Average:F2}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double Average
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}
