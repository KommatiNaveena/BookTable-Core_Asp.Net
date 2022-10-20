using BookTable_Core_Asp.Net.IRepositories;
using BookTable_Core_Asp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTable_Core_Asp.Net.Repositories
{
    public class BookTableRepository: IBookTableRepository
    {
        BookContext bookContext = new BookContext();

        //This Method is Used to Add The Data in The BookTable Record
        public int AddBookTable(BookTable book)
        {
            var data = bookContext.BookTables.Add(book);
            bookContext.SaveChanges();
            return 1;
        }



        //This Method is Used to Get The Data Based On The Id In BookTable
        public BookTable GetBookTableById(Guid Id)
        {
            var data = bookContext.BookTables.Where(a => a.Id == Id).FirstOrDefault();
            return data;
        }


        //This Method is Used to Get The Data From The BookTable Records
        public List<BookTable> GetBookTables()
        {
            var data = bookContext.BookTables.ToList();
            return data;
        }


       
    }
}
