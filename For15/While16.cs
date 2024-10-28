//using System;

//class While16
//{
//    static void Main()
//    {
        
//        double initialDistance = 10.0; 
//        double totalDistance = 0.0; 
//        double percentageIncrease; 
//        int dayCount = 0; 

        
//        Console.Write("Введите процент увеличения пробега (0 < P < 50): ");
//        percentageIncrease = Convert.ToDouble(Console.ReadLine());


//        if (percentageIncrease <= 0 || percentageIncrease >= 50)
//        {
//            Console.WriteLine("Ошибка: процент должен быть больше 0 и меньше 50.");
//            return;
//        }

//        double dailyDistance = initialDistance; 

        
//        while (totalDistance <= 200)
//        {
//            dayCount++;
//            totalDistance += dailyDistance; 
//            dailyDistance += dailyDistance * (percentageIncrease / 100); 
//        }

//        Console.WriteLine($"Количество дней: {dayCount}");
//        Console.WriteLine($"Суммарный пробег: {totalDistance:F2} км");
//    }
//}