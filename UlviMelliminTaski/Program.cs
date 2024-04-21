using System.Collections.Generic;
using UlviMelliminTaski.Models;

namespace UlviMelliminTaski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new Group("AB106");
            Group ab107 = new Group("AB110");

            List<Student> students = new List<Student>();
            students.Add(new Student("Shahin", "Alizade", 21, 190, ab106));
            students.Add(new Student("Qerib", "Qeribzade", 17, 200, ab106));
            students.Add(new Student("Samir", "Karimov", 31, 170, ab107));

          

            students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + " " + s.Name)); // AB106 qrupunda olanlar
            students.FindAll(s => s.Credit < 2400).ForEach(s => Console.WriteLine(s.Id + " " + s.Name)); 
            students.FindAll(s => s == s).ForEach(s => Console.WriteLine(s.Id + " " + s.Name+""+s.Surname)); // Ad Soyadad gore tapmaq
            students.FindAll(s => s.Name.ToLower().Contains("b")).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));// ADINDA B HERFI OLAN TELEBELRI GOSTERSIN
            students.OrderBy(s => s.Credit).ToList().ForEach(s => Console.WriteLine(s.Name+" "+s.Credit)); // TELEBELERI KREDIT SAYINA GORE SIRALIYIRIQ
            Console.WriteLine(students.Sum(s=>s.Credit)); // UMUMI KREDITLERIN CEMINI TAPIRIQ
            Console.WriteLine(students.Any(s=>s.Age<18)); // !8 YASDAN ASAGI TELEBE VAR YA YOX
            Console.WriteLine(students.Any(s => s.Credit < 200));// TELEBELER EN AZI 200 KREDIT ODEYIBMI
            //students.OrderBy(s => s.Group).ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Group)); // Groupa gore siralamaq
            

        } 
    }
}
