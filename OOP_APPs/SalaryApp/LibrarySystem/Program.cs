  
namespace LibrarySystem
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Welcome to the Library System");
            Library library = new Library();
            Console.WriteLine("Are you libraroan pr regular user ? (L/R)");
            var userType = Console.ReadLine().ToUpper()[0];//first index of array of character if user write all letters of word

            if (userType == 'L')
            {
                //librarian logic
                Console.WriteLine("Welcome Librarian Enter Name");
                string LibraianName = Console.ReadLine();
                Librarian l1 = new Librarian(LibraianName);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("please Choose to Add Book (A) / Remove Book (R)/ Display Books / (D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book Details ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine()); // type custiong 
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            l1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter Book Details to remove");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine()); // type custiong 
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            l1.RemoveBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("The Book list :");
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            }
            else if (userType == 'R')
            {
                //user logic
                Console.WriteLine("Welcome User Enter Name");
                string userName = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(userName);
                Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {
                    Console.WriteLine("please Choose to Display Books (D) / Borrow Book (B)");
                    char Choise = Console.ReadLine().ToUpper()[0];
                    switch (Choise)
                    {
                        case 'D':
                            Console.WriteLine("The Book list :");
                            u1.DisplayBooks(library);
                            break;
                        case 'B':
                            Console.WriteLine("Enter Book details To Borrow");
                            Console.WriteLine("Enter Name of book");
                            var bookName = Console.ReadLine();
                            Console.WriteLine("Enter book Author");
                            var bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter book year");
                            var bookYear = Convert.ToInt32(Console.ReadLine()); // type custiong 
                            var book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            u1.BorrowBooks(book, library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }


                }
            }


            else
            {

                Console.WriteLine("Please Enter Correct Value (L or R)");

            }

                }
            }
    }
        
    
