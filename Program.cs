using System;
using System.Globalization;

namespace Curso_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2022, 7, 26);
            DateTime d3 = new DateTime(2022, 7, 26, 21, 35, 03);// Data e Hora
            DateTime d4 = new DateTime(2022, 7, 26, 21, 35, 03,500); // Data, hora e milisegundos(naoa aparece o milisegundos) 
            DateTime d5= DateTime.Today;//Data de hoje às zero Hora
            DateTime d6= DateTime.UtcNow;//Horario de Agora no Meridiano de GreenWich
            DateTime d7= DateTime.Parse("2018-05-21");
            DateTime d8= DateTime.Parse("2018-05-21 13:05:58");
            DateTime d9= DateTime.Parse("26/07/2022");
            DateTime d10= DateTime.Parse("26/07/2022 21:45:05");
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("26/07/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);




        }
    }
}
