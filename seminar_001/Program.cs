// Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное
// на само себя).
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int str = number * number;

//Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();

//Вывод с использованием знака $
Console.WriteLine($"Квадрат числа {number} равен = {str}");

//Вывод собращением к переменным
Console.WriteLine("Квадрат числа {0} равен = {1}", number, str);

//Использование библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr,2);
Console.WriteLine("Квадрат числа {0} равен = {1}", sqr, sqr_2);
