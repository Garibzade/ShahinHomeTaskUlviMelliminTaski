using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlviMelliminTaski.Models
{
    internal class Student
    {
        public Student(string name, string surname, int age, decimal credits, Group group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Credit = credits;
            Group = group;
            Id = Count++;
        }
        static int Count = 0;
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Surname;
        public int Age { get; set; }
        public decimal Credit { get; set; }
        public Group Group { get; set; }


    }
}
