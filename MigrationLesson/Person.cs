using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationLesson
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }
    }
}
