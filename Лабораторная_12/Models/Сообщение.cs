using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_12.Models
{
    public class Сообщение
    {
        public int Id { get; set; }
        public string От_кого { get; set; }
        public string Кому { get; set; }
        public string Заголовок_сообщения { get; set; }
        public string Текст { get; set; }
        public string Дата_отправки { get; set; }
    }
}