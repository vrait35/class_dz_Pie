using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace class_dz
{
    enum Preparation
    {
        fry,
        bake
    }

    class Program
    {
            //тип приготовления
        
        static void Main(string[] args)
        {
            bool isTrue=false;
            int buf = 0;
            while (!isTrue)
            {
                Console.Write("введите количество пирожков: ");
                isTrue = Pie.IsNumber(Console.ReadLine(),ref buf);
            }
            

            Pie[] pie = new Pie[buf];
            for (int i = 0; i < buf; i++)
            {                
                pie[i] = new Pie();
                if (i + 2 == buf) Thread.Sleep(3000);
            }

            Random random = new Random((int)DateTime.Now.Ticks);             
            random.Next(0, buf);

            Console.WriteLine("самый свежий пирожок сделан в : " + pie[random.Next(0, buf)].GetDateTime());                       
            Console.WriteLine("дата создания пирожка pie[{0}]: "+pie[random.Next(0, buf)].GetDate(), random.Next(0, buf));
            Console.ReadKey();
        }
    }
}
