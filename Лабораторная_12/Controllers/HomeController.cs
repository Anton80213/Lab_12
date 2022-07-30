using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Лабораторная_12.Models;

namespace Лабораторная_12.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        Личный_кабинет db = new Личный_кабинет();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Переход2()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Переход2(Пользователь пользователь)
        {
            // добавляем информацию о пользователе в базу данных
            db.Пользователи.Add(пользователь);
            // сохраняем в бд все изменения
            db.SaveChanges();
            MessageBox.Show("Данные сохранены");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Переход3()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Переход3([Bind(Include = "Логин, Пароль")] Пользователь пользователь)
        {
            var result = from x in db.Пользователи
                         select new { a = x.Логин, b = x.Пароль };
            bool n = false;
            foreach (var i in result)
            {
                n = i.a == пользователь.Логин && i.b == пользователь.Пароль;
                if (n == true)
                {
                    MessageBox.Show("Данные верны");
                    break;
                }
            }
            if (n == false)
            {
                MessageBox.Show("Неверный логин или пароль");
                return null;
            }
            else return RedirectToAction("Переход4", new { Логин = пользователь.Логин, Пароль = пользователь.Пароль });
        }

        [HttpGet]
        public ActionResult Переход4(string Логин, string Пароль)
        {
            MyModel model = new MyModel();
            var result = from x in db.Пользователи
                         join y in db.Сообщения on x.Id equals y.Id
                         where x.Логин == Логин && x.Пароль == Пароль
                         select new { a = x.ФИО, b = y.Заголовок_сообщения, c = y.От_кого };
            foreach (var i in result)
            {
                model.ФИО = i.a;
                if (i.b == null && i.c == null)
                {
                    model.Заголовок_сообщения = "Не найдено ни одного сообщения";
                    model.От_кого = "Не найдено ни одного получателя";
                }
                else
                {
                    model.Заголовок_сообщения = i.b;
                    model.От_кого = i.c;
                }
            }
            return PartialView(model);
            
        }
        [HttpGet]
        public ActionResult Переход5(string Заголовок)
        {
            Сообщение model2 = new Сообщение();
            var result = from y in db.Сообщения
                         where y.Заголовок_сообщения == Заголовок
                         select new { a = y.Текст };
            foreach (var i in result)
            {
                model2.Текст = i.a;
            }
            return PartialView(model2);
        }
        [HttpPost]
        public ActionResult Переход5([Bind(Include = "Кому, Текст")] Сообщение сообщение)
        {
            // добавляем информацию о пользователе в базу данных
            db.Сообщения.Add(сообщение);
            // сохраняем в бд все изменения
            db.SaveChanges();
            MessageBox.Show("Данные сохранены");
            return null;
        }
    }
}