using BookTable_Core_Asp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTable_Core_Asp.Net.ILogics
{
   public interface IBookTableLogic
    {
      

        //This Method is Used to Add The Data in The BookTable Record
        public int AddBookTable(BookTable book);



        //This Method is Used to Get The Data From The BookTable Records
        public List<BookTable> GetBookTables();



        //This Method is Used to Get The Data Based On The Id In BookTable
        public BookTable GetBookTableById(Guid Id);


        

    }
}
