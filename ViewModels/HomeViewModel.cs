using KursivProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> favBooks { get; set; }
    }
}
