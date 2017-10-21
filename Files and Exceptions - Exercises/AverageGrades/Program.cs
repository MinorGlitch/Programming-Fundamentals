using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            List<string> studentLines = File.ReadAllLines("input.txt").ToList();

            int inputCount = int.Parse(studentLines[0]);

            List<Student> students = new List<Student>();

            studentLines.RemoveAt(0);

            for (int i = 0; i < inputCount; i++)
            {
                string[] inputArgs = studentLines[0].Split(' ');

                Student student = new Student();

                student.Grades = new List<double>();

                string name = inputArgs[0];

                student.Name = name;

                foreach (string grade in inputArgs.Skip(1))
                {
                    student.Grades.Add(double.Parse(grade));
                }

                students.Add(student);

                studentLines.RemoveAt(0);
            }

            File.WriteAllText("output.txt", String.Empty);

            foreach (Student student in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                if (student.Average >= 5)
                {
                    string currentOutput = $"{student.Name} -> {student.Average:F2}" + Environment.NewLine;

                    File.AppendAllText("output.txt", currentOutput);
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
