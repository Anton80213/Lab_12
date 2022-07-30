using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Лабораторная_12.Models
{
    public class MyDbInitializer : DropCreateDatabaseAlways<Личный_кабинет>
    {
        protected override void Seed(Личный_кабинет db)
        {
            db.Пользователи.Add(new Пользователь { Id = 1, Логин = "gh@yandex.ru", Пароль = "kot", ФИО = "Блинов Р.Г."});
            db.Пользователи.Add(new Пользователь { Id = 2, Логин = "box@yandex.com", Пароль = "lor", ФИО = "Каменева Ю.В."});
            db.Пользователи.Add(new Пользователь { Id = 3, Логин = "dervish@mail.ru", Пароль = "gnom", ФИО = "Тимофеев Д.А." });
            db.Сообщения.Add(new Сообщение { Id = 1, От_кого = "logist", Кому = "MrGuns", Заголовок_сообщения = "Вопрос", Текст = "Привет! Как дела?", Дата_отправки = "15.07.2018" });
            db.Сообщения.Add(new Сообщение { Id = 2, От_кого = "MrGuns", Кому = "Expert", Заголовок_сообщения = "Поздравление", Текст = "С Днём рождения! ", Дата_отправки = "17.07.2019" });
            db.Сообщения.Add(new Сообщение { Id = 3, От_кого = "Expert", Кому = "logist", Заголовок_сообщения = "Заседание кафедры", Текст = "Напоминаю Вам, что заседание кафедры состоится 1 сентября текущего года.", Дата_отправки = "19.08.2020" });
            base.Seed(db);
        }
    }
}