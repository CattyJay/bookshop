using KursivProject.Data.Interfaces;
using KursivProject.Data.Models;
using KursivProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBookCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBookCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }
        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(_category))
            {
                books = _allBooks.Books.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("tragic", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Трагедия")).OrderBy(i => i.id);
                    currCategory = "Трагедия";
                }
                if (string.Equals("comedy", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Комедия")).OrderBy(i => i.id);
                    currCategory = "Комедия";
                }
                if (string.Equals("drama", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Драма")).OrderBy(i => i.id);
                    currCategory = "Драма";
                }
                if (string.Equals("horrors", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Ужасы")).OrderBy(i => i.id);
                    currCategory = "Ужасы";
                }
            }
            var bookObj = new BooksListViewModel
            {
                allBooks = books,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с книгами";
            return View(bookObj);
        }
    }
}
