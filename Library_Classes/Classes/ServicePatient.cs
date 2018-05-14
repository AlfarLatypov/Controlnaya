using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/* Генерация пациентов и их списка 
 * Поиск по ФИО, и по ИИН в базе всех существующих пациентов*/

namespace Library_Classes.Classes
{
    public class ServicePatient
    {

        List<Patient> patientsBase = new List<Patient>();
        Random rand = new Random();

        public void GeneratePatient()
        {
            Generator genr = new Generator();

            /*        SoName: ?<center><b><font size=7>Афанасий
Козлов
</font></b></center>
     Name
      Otchestvo
     IIN 1823546372*/
                 

            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                Patient patient = new Patient();
                patient.Soname = genr.GenerateDefault((Gender)rand.Next(0, 2));
                 patient.Soname.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
        patient.IIN = rand.Next(1000000000, 1999999999).ToString();
                patientsBase.Add(patient);

             
            }

            


        }


        public void PrintPatientsBase()
        {
            foreach (Patient item in patientsBase)
            {
                Console.WriteLine("\n\tSoName: {0}\n\tName {1}\n\t Otchestvo {2}\n\tIIN {3} ", item.Soname, item.Name, item.Otchestvo, item.IIN);
            }
        }



    }
}
