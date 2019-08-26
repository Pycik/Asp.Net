using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookShop.Models
{
    // можем воспользоваться специальным классом, который за нас добавит начальные данные в бд
    /*
     * Класс DropCreateDatabaseAlways позволяет при каждом новом запуске заполнять базу данных 
     * заново некоторыми начальными данными. В качестве таких начальных значений здесь создаются три объекта Book.
     * Используя метод db.Books.Add мы добавляем каждый такой объект в базу данных.
     * Однако чтобы этот класс действительно сработал, и заполнение базы данных произошло, 
     * нам надо запустить его при запуске приложения. Все начальные настройки приложения и 
     * конфигурации находятся в файле Global.asax
     */

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}