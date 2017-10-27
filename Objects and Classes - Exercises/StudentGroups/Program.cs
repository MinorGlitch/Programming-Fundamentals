using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string inputArgs = Console.ReadLine();


            while (inputArgs != "End")
            {
                if (inputArgs.IndexOf("=>") != -1)
                {
                    towns.Add(ReadTown(inputArgs));
                }
                else
                {
                    towns[towns.Count - 1].Students.Add(ReadStudent(inputArgs));
                }

                inputArgs = Console.ReadLine();
            }

            List<Group> groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (Group group in groups.OrderBy(g => g.Name.Name))
            {
                Console.WriteLine($"{group.Name.Name} => {string.Join(", ", group.Students.Select(s => s.Email).ToList())}");
            }
        }

        static Town ReadTown(string input)
        {
            string[] tokens = input.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);

            string townName = tokens[0].Trim();

            int seats = int.Parse(tokens[1].Trim().Split(' ')[0]);

            List<Student> students = new List<Student>();

            return new Town { Name = townName, Seats = seats, Students = students };
        }

        static Student ReadStudent(string input)
        {
            string[] tokens = input.Split('|');

            string name = tokens[0].Trim();

            string email = tokens[1].Trim();

            DateTime registrationDate = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return new Student { Name = name, Email = email, RegistrationDate = registrationDate };
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (Town town in towns)
            {
                List<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();

                while (students.Any())
                {
                    Group group = new Group();

                    group.Name = town;

                    group.Students = students.Take(group.Name.Seats).ToList();

                    students = students.Skip(group.Name.Seats).ToList();

                    groups.Add(group);
                }
            }

            return groups;
        }
    }
    class Group
    {
        public Town Name { get; set; }
        public List<Student> Students { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }


    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
