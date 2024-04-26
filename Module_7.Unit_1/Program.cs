using Module_7.Unit_1.Models;

namespace Module_7.Unit_1
{
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }

    class Food {}
    class Fruits : Food {public string Name;}
    class Vegetables : Food {public string Name;}
    class Apple : Fruits{}
    class Banana : Fruits { }
    class Pear : Fruits { }
    class Potato : Vegetables { }
    class Carrot : Vegetables { }

    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;
        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }

    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }
    class DerivedClass : BaseClass
    {
        public string Description;
        public int Counter;

        public DerivedClass(string name, string Description, int Counter) : base(name)
        {

            this.Description = Description;
            this.Counter = Counter;
        }
        public DerivedClass(string name, string Description) : base(name)
        {
            this.Description=Description;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
