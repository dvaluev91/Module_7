namespace Module_7.Unit_2.Models
{
    public enum FuelType
    {
        Gas = 0,
        Electricity
    }
    public class HybridCar : Car
    {
        public FuelType FuelType;
        public double Gas;
        public double Electricity;

        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Вызван метод Move класса HybridCar");
            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
}
