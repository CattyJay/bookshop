using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursivProject.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Введите имя")]
        [StringLength(15)]
        [Required(ErrorMessage = "Поле обязательно")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Поле обязательно")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Поле обязательно")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Поле обязательно")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Поле обязательно")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        [BindNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
