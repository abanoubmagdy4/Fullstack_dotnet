using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; } // agregaion user has a  library user whem i delete user a library card disapear -- relation type : Tight coupling

        public LibraryUser(string name )
        {
            Name = name;    
        }

        public void BorrowBooks(Book book , Library library)
        {
              library.BorrowBook(book);

            //add logic

        }

    }
}
