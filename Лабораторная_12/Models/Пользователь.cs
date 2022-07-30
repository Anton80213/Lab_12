using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_12.Models
{
    public class Пользователь
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина строки должна быть от 5 до 25 символов")]
        [Display(Name = "Введите логин")]
        public string Логин { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 30 символов")]
        [Display(Name = "Введите пароль")]
        public string Пароль { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 40 символов")]
        [Display(Name = "Введите ФИО")]
        public string ФИО { get; set; }
    }
}