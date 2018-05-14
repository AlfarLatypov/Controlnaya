using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Classes.Classes;



namespace Controlnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePatient servicePatient = new ServicePatient();

            servicePatient.GeneratePatient();
            servicePatient.PrintPatientsBase();


        }
    }
}
