using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProgram
{
    class User
    {
        private Manager m;
        public User()
        {
            m = new Manager();
        }
        public void addBookcall(string isbn, string kind, string name, string author, string publisher, long price)
        {
            m.addBook(isbn, kind, name, author, publisher, price);
        }
        public void delBookcall(string isbn)
        {
            m.delBook(isbn);
        }
        public void findBook(string isbn)
        {
            Console.WriteLine(m.showBook(m.getBookInfo(isbn)));
        }
        public void allBooks()
        {
            m.showAllbooks();
        }


    }
    class Manager
    {
        private List<Book> booklist;
        public Manager()
        {
            this.booklist = new List<Book>();
        }
        public void addBook(string isbn, string kind, string name, string author, string publisher, long price)
        {
            this.booklist.Add(new Book(isbn, kind, name, author, publisher, price));
            Console.WriteLine("도서 추가가 완료 되었습니다.");
        }
        public void delBook(string isbn)
        {

            if (!this.booklist.Exists(x => x.Isbn == isbn))
            {
                Console.WriteLine("존재하지 않는 도서입니다.\n");
                return;
            }
            else
            {
                this.booklist.RemoveAt(this.booklist.FindIndex(x => x.Isbn == isbn));
                Console.WriteLine("해당 도서가 삭제되었습니다.\n");
            }
        }

        public Book getBookInfo(string isbn)
        {
            if (!this.booklist.Exists(x => x.Isbn == isbn))
            {
                Console.WriteLine("존재하지 않는 도서입니다.\n");
                return default;
            }
            else
            {
                Console.WriteLine("찾으시는 도서입니다.");
                return this.booklist.Find(x => x.Isbn == isbn);
            }
        }

        public void showAllbooks()
        {
            Console.WriteLine("== 도서 목록 ==");
            foreach (Book item in this.booklist)
            {
                Console.WriteLine(showBook(item)); ;
            }
            Console.WriteLine();
        }

        public string showBook(Book book)
        {
            if (book != null)
            {
                return book.Isbn + " " + book.Kind + " " +book.Name + " " + book.Author + " " + book.Publisher + " " + book.Price + "원";
            }
            return null;
        }

    }

    class Book
    {
        private string isbn;
        private string kind;
        private string name;
        private string author;
        private string publisher;
        private long price;
        public Book(string isbn, string kind, string name, string author, string publisher, long price )
        {
            this.isbn = isbn;
            this.name = name;
            this.kind = kind;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
        }


        public string Isbn { get => isbn; }
        public string Name { get => name; }
        public string Author { get => author; }
        public string Publisher { get => publisher; }
        public long Price { get => price; }
        public string Kind { get => kind; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.addBookcall("1234567","철학", "군주론", "니콜로 마키아벨리", "현대지성", 6930);
            u.addBookcall("7894561", "철학", "도덕경", "노자", "현대지성", 10800);
            u.addBookcall("8412357", "역사소설", "삼국지01", "나관중", "알에이치코리아", 10360);
            u.addBookcall("3456789", "프로그래밍", "C#교과서", "박용준", "길벗", 30000);
            u.allBooks();
            u.findBook("8412357");
            u.delBookcall("7894561");
            u.allBooks();
            u.findBook("7894561");
            u.delBookcall("7894561");
        }
    }

}
