using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10
{
    public class Task2
    {
        public void Book()
        {
            Book book;
            Console.WriteLine("Название и автор книги, через /:");
            string[] input = Console.ReadLine().Split('/');

            Console.WriteLine("Содержание книги:");
            var content = Console.ReadLine();

            book = new Book(input[1], input[0], content);
            book.Show();
            Console.ReadKey();
        }
    }
    class Book
    {
        public Title SomeTitle { get; set; }
        public Author SomeAuthor { get; set; }
        public Content SomeContent { get; set; }
        public void Show()
        {
            SomeTitle.Show();
            SomeAuthor.Show();
            SomeContent.Show();
        }
        public Book()
        {
            SomeTitle = new Title();
            SomeAuthor = new Author();
            SomeContent = new Content();
        }
        public Book(string titleBook, string authorBook, string contentBook)
        {
            SomeTitle = new Title();
            SomeAuthor = new Author();
            SomeContent = new Content();
            SomeTitle.title = titleBook;
            SomeAuthor.author = authorBook;
            SomeContent.content = contentBook;
        }
    }
    class Title
    {
        public string title { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Название книги : {title}");
            Console.ResetColor();
        }
    }
    class Author
    {
        public string author { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Автор книги : {author}");
            Console.ResetColor();
        }
    }
    class Content
    {
        public string content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Содержание книги : {content}");
            Console.ResetColor();
        }
    }
}
