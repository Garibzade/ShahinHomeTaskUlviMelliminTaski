using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlviMelliminTaski.Models
{
    internal class Group
    {
        public Group(string name)
        {
            Id = Count++;
            Name = name;
        }
        static int Count = 0;
        public int Id { get; set; } = 0;
        public string Name { get; set; }

    }
}
