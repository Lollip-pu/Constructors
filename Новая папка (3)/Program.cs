using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Book
    {
        private string title;
        private int pages;
        public string Title {  get { return title; } set { title = value; } }
        public int Pages { get { return pages; } set { 
                if (value >= 1 && value <= 5000)
                pages = value;
                else
                    Console.WriteLine("Страниц должно быть от 1 до 5000");
            } }
        public Book (string title, int pages) : this ()
        {
            this.title = title;
            this.pages = pages >= 1 && pages <= 5000 ? pages : 0;
        }
        public Book (string title) {  this.title = title; this.pages = 100; }
        public Book()
        {
            this.title = "без названия";
            this.pages = 1;
        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу {title} , страниц {pages}");
        }
        }
        class Program
    {static void Main()
        {
            Book book = new Book();
            Book book1 = new Book("Война и мир", 1200);
            Book book2 = new Book("1984", 100);
            book.Read();
            book1.Read();
            book2.Read();

        }
    }
}
