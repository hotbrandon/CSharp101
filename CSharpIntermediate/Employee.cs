using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // static constructor does not take access modifiers or any parameters
        static Employee()
        {
            Console.WriteLine("the static constructor gets called only once, no matter how many objects are instantiated");
        }
        // default constructor
        public Employee()
        {
            Console.WriteLine("The default constructor gets called upon object instantiation");
        }
    }
}
