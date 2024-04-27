using Module_7.Unit_2._2.Models;

namespace Module_7.Unit_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //D d = new D();
            //E e = new E();

            //d.Display(); // Вывод на экран "D"
            //((A)e).Display(); // Вывод на экран "C"
            //((B)d).Display(); // Вывод на экран "B"
            //((A)d).Display(); // Вывод на экран "A"

            //Vector a = new Vector() { X = 3, Y = 5};
            //Vector b = new Vector() { X = 7, Y = 13};

            //Vector c = a.Add(b);
            //Vector f = a + b;
            //Vector g = +a;
            //Vector h = a + (10, -5);
            //Console.WriteLine($"{c.X}, {c.Y}");
            //Console.WriteLine($"{f.X}, {f.Y}");
            //Console.WriteLine($"{g.X}, {g.Y}");

            //Obj obj1 = new Obj() { Value = 4};
            //Obj obj2 = new Obj() { Value = 5};
            //Obj obj3 = obj1 + obj2;
            //Obj obj4 = obj1 - obj2;
            //Console.WriteLine($"{obj3.Value}, {obj4.Value}");

            var array = new Book[]
                {
                    new Book
                    {
                        Name = "Мастер и Маргарита",
                        Author = "М.А. Булгаков"
                    },
                    new Book
                    {
                        Name = "Отцы и дети",
                        Author = "И. С. Тургенев"
                    },
                };
            BookCollection collection = new BookCollection(array);
            Book book = collection[1];

            book = collection["Мастер и Маргарита"];
        }
    }
}
