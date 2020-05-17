using KursivProject.Data.Interfaces;
using KursivProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Data.Mocks
{
    public class MockCategory : IBookCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Комедия", desc = "Тип смешной жанр, чисто покекать"},
                    new Category {categoryName = "Трагедия", desc = "Печальное жанр, пробьёт на слёзы всех равнодушных"},
                    new Category {categoryName = "Драма", desc = "То же что и трагедия, только более приближенно к реальной жизни"},
                    new Category {categoryName = "Ужасы", desc = "Страшнее смерти, заставит дрожать коленки даже самых смелых"}
                };
            }
        }
    }
}
