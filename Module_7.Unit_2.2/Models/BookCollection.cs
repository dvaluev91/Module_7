using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2._2.Models
{
    internal class BookCollection // Класс для объявления "Коллекции книг"
    {
        private Book[] collection; //Закрытое поле, хранящее книги в виде массива
        public BookCollection(Book[] collection) // Конструктор с добавлением массива книг
        {
            this.collection = collection;
        }
        public Book this[int index] // Индексатор по массиву
        {
            get 
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }
            private set 
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
        public Book this [string name]
        {
            get 
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i].Name == name)
                    {
                        return collection[i];
                    }
                }
                return null;
            }
        }
    }
}
