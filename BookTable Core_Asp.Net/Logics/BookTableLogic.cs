using BookTable_Core_Asp.Net.ILogics;
using BookTable_Core_Asp.Net.IRepositories;
using BookTable_Core_Asp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTable_Core_Asp.Net.Logics
{
    public class BookTableLogic : IBookTableLogic
    {
        IBookTableRepository bookTableRepository;
        public BookTableLogic(IBookTableRepository _bookTableRepository)
        {
            bookTableRepository = _bookTableRepository;
        }

        //This Method is Used to Add The Data in The BookTable Record
        public int AddBookTable(BookTable book)
        {
            return bookTableRepository.AddBookTable(book);
        }
        //This Method is Used to Get The Data Based On The Id In BookTable
        public BookTable GetBookTableById(Guid Id)
        {
            return bookTableRepository.GetBookTableById(Id);
        }

        //This Method is Used to Get The Data From The BookTable Records
        public List<BookTable> GetBookTables()
        {
            return bookTableRepository.GetBookTables();
        }

      
    }
}
