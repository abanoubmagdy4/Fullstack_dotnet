using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books = new Book[100]; // intial array of books property in library class
        private int CurrentBookCount =0;
        private Book[] borrowBooks = new Book[50];
        private int CurrentBorrowedBookCount = 0;
        public void Add(Book book) {
            //add logic 
            if (CurrentBookCount < books.Length)
            {
                books[CurrentBookCount] = book;
                CurrentBookCount++;
                // عملنا عداد علشان نعرف احنا واقفين علي اي اندكس في الأراي وبالتالي هتأكد أنا عديت القيمة بتاعة الأراي ولا لا
                Console.WriteLine("Book Added Succesfully"); 
            }
            else {

                Console.WriteLine("Library is Full  , can add new books");
            }

        }
        public void Remove(Book book) {
            //add logic
           int index =Array.IndexOf(books, book); //method in array class arguments array of list and book its return index of element
            books[index] = null;
            CurrentBookCount--;
            Console.WriteLine("Book Removed Succesfully");

        }
        public void Display() {
            
                 for(int i = 0; i <CurrentBookCount; i++) {
                Console.WriteLine(books[i].Title);

                }


            }
        public void BorrowBook(Book book) {
            if (CurrentBorrowedBookCount < borrowBooks.Length)
            {
                books[CurrentBorrowedBookCount] = book;
                CurrentBorrowedBookCount++;
                // عملنا عداد علشان نعرف احنا واقفين علي اي اندكس في الأراي وبالتالي هتأكد أنا عديت القيمة بتاعة الأراي ولا لا
                Console.WriteLine("Book Borrowed ");
            }
            else
            {

                Console.WriteLine("sorry cant borrow more books");
            }
        }
           



                    }
    }

