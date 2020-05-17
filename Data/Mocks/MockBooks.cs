using KursivProject.Data.Interfaces;
using KursivProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBookCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books 
        {
            get
            {
                return new List<Book>
                {
                    new Book {
                        name = "451° по Фаренгейту",
                        author = "Рей Брэдбери",
                        shortDesc = "Научно-фантастический роман-антиутопия",
                        longDesc = "Роман описывает американское общество близкого будущего, в котором книги находятся под запретом; «пожарные», к числу которых принадлежит и главный герой Гай Монтэг, сжигают любые найденные книги.",
                        price = 5000,
                        isBetseller = true,
                        img = "/img/451° по Фаренгейту.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(1)},
                    new Book {
                        name = "1984",
                        author = "Джордж Оруэлл",
                        shortDesc = "роман-антиутопия Джорджа Оруэлла, изданный в 1949 году",
                        longDesc = "Название романа, его терминология и даже имя автора впоследствии стали нарицательными и употребляются для обозначения общественного уклада, напоминающего описанный в романе «1984» тоталитаризм.",
                        price = 4500,
                        isBetseller = true,
                        img = "/img/1984.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(1)},
                    new Book {
                        name = "Ни океанов ни морей...",
                        author = "Евгений Алёхин",
                        shortDesc = "Небольшой рассказик, пропитанный простым людским повествованием",
                        longDesc = "Рассказ от первого лица, в котором описан типичный день парня в обычном провинциальном городке, живущего без всяких забот",
                        price = 1488,
                        isBetseller = false,
                        img = "/img/Ни океанов ни морей.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(3)},
                    new Book {
                        name = "Перед зеркалом",
                        author = "Вениамин Каверин",
                        shortDesc = "Непопулярный роман, за который нестыдно",
                        longDesc = "Роман \"Перед зеркалом\", представленный в настоящем издании, написан Кавериным в возрасте семидесяти лет и нередко признается его лучшей книгой",
                        price = 2000,
                        isBetseller = false,
                        img = "/img/Перед зеркалом.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(1)},
                    new Book {
                        name = "Смертельная кастрюля, или Возвращение Печенюшкина",
                        author = "Сергей Белоусов",
                        shortDesc = "Прикольная сказочка для людей любого возраста",
                        longDesc = "Прекрасная сказка, добрая, местами наивная\nЛюбимая книга моего детства!\nЖаль, что немногие ее читали и что нет экранизаций\nЭто мог бы быть наш \"ответ\" Гарри Поттеру",
                        price = 817,
                        isBetseller = false,
                        img = "/img/Приключения Печенюшкина.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(0)},
                    new Book {
                        name = "Унесённые ветром",
                        author = "Маргарет Митчелл",
                        shortDesc = "Достойный роман для всей семьи",
                        longDesc = "Роман американской писательницы Маргарет Митчелл (1900–1949) «Унесенные ветром» (1936) – увлекательное по сюжету, остросоциальное произведение, основной проблемой которого является судьба человеческих ценностей в мире купли-продажи. Действие книги происходит в один из наиболее сложных периодов в истории США и охватывает годы Гражданской войны (1861–1865) и последующей за ней Реконструкции",
                        price = 6000,
                        isBetseller = true,
                        img = "/img/Унесённые ветром.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(2)},
                    new Book {
                        name = "Побудь в моей шкуре",
                        author = "Мишель Фейбер",
                        shortDesc = "Вууууу, если у вас какие-то проблемы с психикой и излишние испуги, то вам это противопоказано!!",
                        longDesc = "После романа «Побудь в моей шкуре» Мишель Фейбер страшновато ездить по дорогам Шотландии. А ну как всё это не выдумка и по ним действительно колесит Иссерли, подбирая мужчин-автостопщиков? И те после встречи с ней исчезают бесследно... Кто такая Иссерли, откуда она свалилась на землю и кому служит? По мотивам книги снята леденящая кровь экранизация со Скарлетт Йоханссон в главной роли",
                        price = 10000,
                        isBetseller = true,
                        img = "/img/Under_the_skin.png",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(3)},
                    new Book {
                        name = "Стальной алхимик. Книга 6",
                        author = "Хирому Аракава",
                        shortDesc = "Legendary манга",
                        longDesc = "Легендарная серия манги показывает нам альтернативный 20-й век, в котором магия и алхимия идут в ногу с технологическим процессом. В центре сюжета два брата, Эдвард и Альфонс, попытка которых воскресить умершую мать с помощью алхимии приводит к ужасным последствиям…",
                        price = 120,
                        isBetseller = false,
                        img = "/img/FullMetalAlchemist.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(2)},
                    new Book {
                        name = "Как важно быть серьезным",
                        author = "Оскар Уайльд",
                        shortDesc = "Комедия Оскара Уайльда, больше нет слов для описания",
                        longDesc = "Пьеса была задумана в 1894 г. и поставлена 14 февраля 1895 г. в Сент-Джеймсском театре (Лондон). Спектакль едва не завершился скандалом — маркиз Куинсберри, подозревавший Уайльда в совращении своего сына Альфреда, хотел сорвать постановку, но драматург вовремя предупредил полицию",
                        price = 1500,
                        isBetseller = true,
                        img = "/img/The_Importance_Of_Being_Earnest.jpg",
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(0)},
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
