﻿using KursivProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> allBooks { get; set; }
        public string currCategory { get; set; }

    }
}
