using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Redlips.Models
{
    public class Data
    {
        // ФИО клиента
        public string nameID { get; set; }
        // Номер телефона для обратной связи с клиентом
        public int numberPhone { get; set; }
        // Пожелания к заказу
        public string Wishes { get; set; }
    }
}