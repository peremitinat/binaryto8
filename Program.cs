using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTo8
{
    internal class Program
    {
        static void Main(string[] args) //Стартовая функция главного класса программы
        {
            //Вывод приглашения на экран
            Console.WriteLine("Введите двоичное чиcло: ");
            //Ввод строки, конвертация ее из указанной СС в 10-тичную
            int i = Convert.ToInt32(Console.ReadLine(), 2);
            //Сконвертированное в 10-тичную переконвертируется в 8-ричную
            string s = Convert.ToString(i, 8);
            //Вывод результата
            Console.WriteLine("В восьмеричной системе счисления это: " + s);
            //Просим консоль не закрываться сразу.
            Console.ReadLine();

        }
    }
}
