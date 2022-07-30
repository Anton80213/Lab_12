using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_12.Models
{
    public class MyModel
    {
        [Key]
        public string ФИО { get; set; }
        public string Заголовок_сообщения { get; set; }
        public string От_кого { get; set; }
    }
}