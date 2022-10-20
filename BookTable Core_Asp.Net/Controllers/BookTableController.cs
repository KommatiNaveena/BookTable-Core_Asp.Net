using BookTable_Core_Asp.Net.ILogics;
using BookTable_Core_Asp.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTable_Core_Asp.Net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTableController : ControllerBase
    {
        IBookTableLogic bookTableLogic;
        public BookTableController(IBookTableLogic _bookTableLogic)
        {
            bookTableLogic = _bookTableLogic;
        }

        //This Method is Used to Add The Data in The BookTable Record
        [Route("api/AddBookTable")]
        [HttpPost]
        public int AddBookTable(BookTable book)
        {
            return bookTableLogic.AddBookTable(book);
        }

        //This Method is Used to Get The Data Based On The Id In BookTable
        [Route("api/GetBookTableById/{Id}")]
        [HttpGet]
        public BookTable GetBookTableById(Guid Id)
        {
            return bookTableLogic.GetBookTableById(Id);
        }

        //This Method is Used to Get The Data From The BookTable Records
        [Route("api/GetBookTables")]
        [HttpGet]
        public List<BookTable> GetBookTables()
        {
            return bookTableLogic.GetBookTables();
        }

      
    }
}
