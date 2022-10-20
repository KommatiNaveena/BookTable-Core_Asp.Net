using System;
using System.Collections.Generic;

#nullable disable

namespace BookTable_Core_Asp.Net.Models
{
    public partial class BookTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
    }
}
