using KursivProject.Data.Interfaces;
using KursivProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Data.Repository
{
    public class BookRepository : IAllBooks
    {
        private readonly AppDBContent appDBContent;
        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> Books => appDBContent.Book.Include(c => c.Category);

        public IEnumerable<Book> getFavBooks => appDBContent.Book.Where(p => p.isBetseller).Include(c => c.Category);

        public Book getObjectBook(int bookId) => appDBContent.Book.FirstOrDefault(p => p.id == bookId);
    }
}
