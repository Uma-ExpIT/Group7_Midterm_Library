using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        public static void Main()
        {
            List<Book> book = new List<Book> { };
            book.Add(new Book("Gone with the wind", "Margeret Mitchell", "Fiction", 1936));
            book.Add(new Book("The book theif", "Markus Zusak", "Fiction", 2006));
            book.Add(new Book("Dune", "Frank Herbertt", "Sci-fi", 1965));
            book.Add(new Book("The Giver", "Lois Lowry", "Sci-fi", 1993));
            book.Add(new Book("Animal Farm", "George Orwell", "Sci-fi", 1945));
            book.Add(new Book("The Da Vinci Code", "Dan Brown", "Mystry", 2003));
            book.Add(new Book("Gone Girl", "Gillian Flynn", "Mystry", 2012));
            book.Add(new Book("Easy", "Tammara Webber", "Romance", 2012));
            book.Add(new Book("War and peace", "Leo Tolstoy", "Nonfiction", 1867));
            book.Add(new Book("The kite runner", "Khaled Hossieni", "Nonfiction", 2003));



            Console.WriteLine("Menu \n"
                + "1 for Add new book \n"
                + "2 for Search by book name \n"
                + "3 for Search by author name \n"
                + "4 for Search by genre \n"
                + "5 for Quit");
            Console.WriteLine("Choose Menu option: ");
            int option = Convert.ToInt32(Console.ReadLine());




        }
    }
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublishingYear { get; set; }

        public Book(string bookName, string author, string genre, int publishingYear)
        {
            this.BookName = bookName;
            this.Author = author;
            this.Genre = genre;
            this.PublishingYear = publishingYear;
        }
    }
}