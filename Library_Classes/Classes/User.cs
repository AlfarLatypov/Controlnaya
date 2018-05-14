using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Пользователи (Логин, Пароль, Права доступа, Мед организация)*/
namespace Library_Classes.Classes
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string DAL { get; set; }
        public string MedOrgName { get; set; }

    }
}
