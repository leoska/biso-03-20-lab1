using System;
using System.Collections.Generic;
using System.IO;



namespace biso_03_20_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Стэк, массив и пузырьковая сортировка
            // Написать свой класс стэка с необходимыми методами для работы

            Stack stack = new Stack();
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                stack.Push(rnd.Next(1, 100));
            }
            stack.Print();

            for (int i = 0; i < stack.Count(); ++i)
            {
                for (int j = 0; j < stack.Count() - 1 - i; ++j)
                {
                    if (stack.Get(j) > stack.Get(j + 1))
                    {
                        int tempValue = stack.Get(j);
                        stack.Set(j, stack.Get(j + 1));
                        stack.Set(j + 1, tempValue);
                    }
                }
            }
            stack.Print();
        }
    } 
}
