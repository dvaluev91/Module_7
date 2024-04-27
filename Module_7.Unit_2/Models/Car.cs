namespace Module_7.Unit_2.Models
{
    public class Car
    {
        public int Mileage;

        public Car()
        {
            Mileage = 0;
        }
        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car");
            Mileage++;
        }
    }
}
