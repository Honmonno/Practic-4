//using System;

//class Series23
//{
//    static void Main()
//    {

//        Console.Write("Введите целое число N (> 2): ");
//        int N = Convert.ToInt32(Console.ReadLine());


//        if (N <= 2)
//        {
//            Console.WriteLine("Ошибка: N должно быть больше 2.");
//            return;
//        }


//        double[] numbers = new double[N];


//        Console.WriteLine($"Введите {N} вещественных числа:");
//        for (int i = 0; i < N; i++)
//        {
//            numbers[i] = Convert.ToDouble(Console.ReadLine());
//        }


//        for (int i = 1; i < N - 1; i++)
//        {
//            if (!((numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) ||
//                  (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])))
//            {
//                Console.WriteLine($"Первый элемент, не являющийся зубцом: номер {i + 1}");
//                return;
//            }
//        }


//        Console.WriteLine("0");
//    }
//}