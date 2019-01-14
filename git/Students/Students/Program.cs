using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] group = new string[8][]; //ступенчатый массив, включающий в себя студентов и их отметки
            group[0] = new string[9];
            group[1] = new string[9];
            group[2] = new string[9];
            group[3] = new string[9];
            group[4] = new string[9];
            group[5] = new string[9];
            group[6] = new string[9];
            group[7] = new string[9];

            double groupMiddleMark = 0; //переменная для среднеарифметической отметки всех студентов в группе

            group[0][0] = "1";
            group[0][1] = "Иванова";
            group[0][2] = "Василиса";
            group[0][3] = "9";
            group[0][4] = "10";
            group[0][5] = "9";
            group[0][6] = "10";
            group[0][7] = "9";

            group[1][0] = "2";
            group[1][1] = "Петров";
            group[1][2] = "Антон";
            group[1][3] = "8";
            group[1][4] = "10";
            group[1][5] = "8";
            group[1][6] = "9";
            group[1][7] = "7";

            for (int i = 2; i < group.Length; i++) //цикл для заполнения информации о студентах
            {
                group[i][0] = Convert.ToString(i+1);
                Console.WriteLine("Введите фамилию студента");
                group[i][1] = Console.ReadLine();
                Console.WriteLine("Введите имя студента");
                group[i][2] = Console.ReadLine();
                Console.WriteLine("Введите отметки студента");
                for (int j = 3; j < group[i].Length - 1; j++)
                {
                    group[i][j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < group.Length; i++)//цикл для подсчета среднеарифетических отметок студентов
            {
                double middleMark = 0;
                for (int j = 3; j < group[i].Length - 1; j++)
                {
                    if (group[i][j] == "") 
                    {
                        middleMark += 0;
                    }
                    else
                    {
                        middleMark = middleMark + Convert.ToDouble(group[i][j]);
                    }
                }
                middleMark = middleMark / 5;
                group[i][8] = Convert.ToString(middleMark);
                groupMiddleMark += middleMark;
            }


            for (int i = 0; i < group.Length; i++) //вывод информации о студентах
            {
                for (int j = 0; j < group[i].Length - 1; j++)
                {
                    Console.Write(group[i][j] + " " );
                }
                for (int j = 0; j < 1; j ++ )
                {
                    Console.Write("Среднеарифметическая оценка: " + group[i][7]);
                }
                    Console.WriteLine("");
            }
            Console.WriteLine("Среднеарифметическая отметка группы = " + Convert.ToString(groupMiddleMark / 8)); //вывод среднеарифметической отметки всей группы
        }
      }
}
