//  Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//РЕШЕНИЕ

// Console.WriteLine("Введите число A");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int numberB = int.Parse(Console.ReadLine());
// if(numberA > numberB){
//     Console.WriteLine($"Первое число {numberA} больше второго {numberB} ");
// }
// else{
//     Console.WriteLine($"Второе число {numberB} больше первого {numberA} ");
// }






// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//РЕШЕНИЕ

// Console.WriteLine("Введите первое число для сравнения: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число для сравнения: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число для сравнения: ");
// int num3 = int.Parse(Console.ReadLine()!);
// if(num1 > num2);
// else if (num2 > num3){
//     Console.WriteLine($"Определили максимальное число {num2} ");
// }
// else{
//     Console.WriteLine($"Определили максимальное число {num3} ");
// }
// if(num1 > num3){
//     Console.WriteLine($"Определили максимальное число {num1} ");
// }
// else{
//     Console.WriteLine($"Определили максимальное число {num3} ");
// }


//Задача 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// РЕШЕНИЕ

// Console.WriteLine("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// if(num1 % 2 == 0){
//     Console.WriteLine("Это число четное ");
// }
// else{
//     Console.WriteLine("Это число не четное ");
// }




// Задача 8
//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//РЕШЕНИЕ

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int numMin = 1;
// while (numMin <= num){
//     int result = numMin % 2;
//     if (result != 1){
//         Console.Write($"{numMin}, ");
//         numMin++;
//     }
//     else{
//         numMin++;
//     }
// }

