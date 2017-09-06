using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Motobyke[] motobyke = new Motobyke[5];
            Console.WriteLine("Количестов мотоциклов");
            int CountOfmotobykes;
            string strCountOfmotobykes = Console.ReadLine();
            if(Int32.TryParse(strCountOfmotobykes, out CountOfmotobykes))
            {
                CountOfmotobykes = Int32.Parse(strCountOfmotobykes);
            }
            else
            {
                CountOfmotobykes = 1;
            }
            for (int i = 0; i < CountOfmotobykes; i++)
            {
                Console.WriteLine("Мотоцикл №{0}", i+1);
                motobyke[i] = new Motobyke();
                motobyke[i].Init();
            }
            for (int i = 0; i < CountOfmotobykes; i++)
            {
                motobyke[i].Show();
            }

            Console.ReadLine();
        }
    }
}
