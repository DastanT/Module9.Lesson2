using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Lesson2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Book> books = new List<Book>();
            List<Article> articles = new List<Article>();
            List<Eresource> eresources = new List<Eresource>();

            Console.Write("Введите количество изданий: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Book book = new Book();

                book.Autor = string.Format("{0}", rnd.Next(1, 1000));
                book.BookName = string.Format("{0}", rnd.Next(1, 100));
                book.Year = DateTime.Today.AddDays(rnd.Next(1, 1000) * -1);
                book.NamePublication = string.Format("{0}", rnd.Next(1, 50));
                book.Date = DateTime.Now.AddDays(rnd.Next(1, 1000) * -1);
                book.City = string.Format("{0}", rnd.Next(1, 500));
                books.Add(book);
            }

            Console.WriteLine("Книги.");
            Console.WriteLine();
            foreach (Book book in books)
            {
                book.PrintInfo();
            }


            Console.Write("Найти книгу по автору: ");
            string userBook = Console.ReadLine();
            FindBook(books, userBook);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Статьи.");
            Console.WriteLine();
            InitMagazine(size, articles, rnd);
            foreach (Article article in articles)
            {
                article.PrintInfo();
            }
            Console.Write("Найти статью по автору: ");
            string userArticle = Console.ReadLine();
            FindArticle(articles, userArticle);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Электронный ресурс.");
            Console.WriteLine();
            InitEresource(size, eresources, rnd);
            foreach (Eresource eresource in eresources)
            {
                eresource.PrintInfo();
            }
            Console.Write("Найти статью по автору: ");
            string userResource = Console.ReadLine();
            FindResource(eresources, userResource);
            Console.ReadKey();
            Console.Clear();


        }
        public static void FindBook(List<Book> books, string userIn)
        {
            Book obj = books.Find(w => w.Autor == userIn);
            if (obj != null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                obj.PrintInfo();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Автор не найден");
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        public static void InitMagazine(int size, List<Article> articles, Random rnd)
        {
            for (int i = 0; i < size; i++)
            {
                Article article = new Article();
                article.Autor = string.Format("{0}", rnd.Next(1, 200));
                article.ArticleName = string.Format("{0}", rnd.Next(1, 1000));
                article.MagazineName = string.Format("{0}", rnd.Next(1, 100));
                article.MagazineNumber = rnd.Next(1, 10000);
                article.Date = DateTime.Now.AddDays(rnd.Next(1, 1000) * -1);
                articles.Add(article);
            }
        }
        public static void FindArticle(List<Article> articles, string userIn)
        {
            Article obj = articles.Find(w => w.Autor == userIn);
            if (obj != null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                obj.PrintInfo();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Автор не найден");
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        public static void InitEresource(int size, List<Eresource> eresources, Random rnd)
        {
            for (int i = 0; i < size; i++)
            {
                Eresource eresource = new Eresource();
                eresource.Autor = string.Format("{0}", rnd.Next(1, 200));
                eresource.Ename = string.Format("{0}", rnd.Next(1, 1000));
                eresource.Linq = string.Format("{0}", rnd.Next(100, 10000));
                eresource.Anotation = string.Format("{0}",rnd.Next(1, 10000));
                eresources.Add(eresource);
            }
        }
        public static void FindResource(List<Eresource> eresources, string userIn)
        {
            Eresource obj = eresources.Find(w => w.Autor == userIn);
            if (obj != null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                obj.PrintInfo();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Автор не найден");
                Console.WriteLine();
            }
            Console.ResetColor();
        }

    }
}
