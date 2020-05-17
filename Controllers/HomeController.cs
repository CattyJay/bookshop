using KursivProject.Data.Interfaces;
using KursivProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllBooks _bookRep;

        public HomeController(IAllBooks bookRep)
        {
            _bookRep = bookRep;
        }
        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                favBooks = _bookRep.getFavBooks
            };
            return View(homeBooks);
        }
    }
}
