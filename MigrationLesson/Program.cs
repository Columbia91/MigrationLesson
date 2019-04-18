using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FullName = "Пушкин А.С.",
                Gender = "мужской",
                Age = 86
            };
            
            using(var context = new DataContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }
    }
}
