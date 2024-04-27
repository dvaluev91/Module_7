using Module_7.Unit_2.Models;

namespace Module_7.Unit_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            HybridCar hybridcar = new HybridCar();
            hybridcar.FuelType = FuelType.Gas;
            hybridcar.Move();
            //((Car)hybridcar).Move();

            //Задание 7.2.3
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();
            //((BaseClass)derivedClass).Display();

            //Citizen citizen = new Citizen();
            //citizen.Age = 10;
            //Console.WriteLine(citizen.Age);

            //President president = new President();
            //president.Age = 36;
            //president.SayYourAge();

        }
    }
}
