using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Пациент (Фамилия, Имя, Отчество, ИИН)*/

namespace Library_Classes.Classes
{
   public class Patient
    {
        public string Soname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string IIN { get; set; }

    }
}
