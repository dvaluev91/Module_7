using Module_7.Unit_2._1.Models;

namespace Module_7.Unit_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();
            b.Display();
            ((A)b).Display();

            Console.WriteLine();

            c.Display();
            ((A)c).Display();
            ((B)c).Display();
        }
    }
}
