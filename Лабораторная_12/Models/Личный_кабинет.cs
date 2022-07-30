using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Лабораторная_12.Models
{
    public class Личный_кабинет : DbContext
    {
        public DbSet<Пользователь> Пользователи { get; set; }
        public DbSet<Сообщение> Сообщения { get; set; }
        public DbSet<MyModel> MyModels { get; set; }
    }
}