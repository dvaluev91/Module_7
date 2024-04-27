using Module_7.Unit_3.Models;

namespace Module_7.Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Николай", true);
            Guest guest = new Guest("Андрей", new DateTime(2020, 11, 05));

            Person person = employee;
            person = guest;
            employee.DisplayName();
            guest.DisplayName();

            Dog dog = new Dog();
            dog.Name = "Тобик";
            Cat cat = new Cat();
            cat.Name = "Барсик";

            dog.Describe();
            cat.Describe();
            FourLeggedAnimal animal = dog;
            animal.Describe(); //dog

            animal = cat;
            animal.Describe();// cat
        }
    }
}
