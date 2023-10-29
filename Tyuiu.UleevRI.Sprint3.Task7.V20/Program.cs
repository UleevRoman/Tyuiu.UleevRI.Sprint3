using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint3.Task7.V20.Lib;

namespace Tyuiu.UleevRI.Sprint3.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 20                                                              *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая таблицу значений функции:                   *");
            Console.WriteLine("* (sin(x)-2x)/(3x-1) + sin(x) - 3x + 2                                    *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапозоне [-5; 5] с шагом 1.*");
            Console.WriteLine("* Произвести проверку деления на ноль. При делениии на ноль вернуть       *");
            Console.WriteLine("* значение 0. Значения округлять до двух знакоми после запятой. Значения  *");
            Console.WriteLine("* занести в массив!                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int l = ds.GetMassFunction(startValue, stopValue).Length;
            double[] num = new double[l];
            num = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= l-1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, num[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
