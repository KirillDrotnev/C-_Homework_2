//Задача 1


// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 999)
{
    Console.Write($"Введенное число некорректно {num}");
}
else
{
    // int num1 = num % 10;
    // num = num - num1;
    int num2 = (num / 100) % 10;
    Console.Write($"Вторая цифра числа {num2}");
}


// Задача 2

//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

if (num1 > 99 && num1 < 1000)
{
    int num2 = (num1 % 100) / 10;
    System.Console.WriteLine($"Третья цифра {num2}");
}
else
{
    System.Console.WriteLine("Вы ввели некорректное число");
}

// К сожалению смог сделать только в интервале. 
// Думаю можно сделать через массив с помощью индекса, но до этого мы еще не дошли.

// Задача 3

// Вариант 1 - Рабочий

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите число:");
string strNum = Console.ReadLine();
int WeekDay = int.Parse(strNum);

if (WeekDay == 1)
{
    Console.WriteLine("Рабочий день");
}

else if (WeekDay == 2)
{
    Console.WriteLine("Рабочий день");
}

else if (WeekDay == 3)
{
    Console.WriteLine("Рабочий день");
}

else if (WeekDay == 4)
{
    Console.WriteLine("Рабочий день");
}

else if (WeekDay == 5)
{
    Console.WriteLine("Рабочий день");
}

else if (WeekDay == 6)
{
    Console.WriteLine("Выходной день");
}

else if (WeekDay == 7)
{
    Console.WriteLine("Выходной день");
}

else
{
    Console.WriteLine("Вы ввели некорректное число");
}


// Вариант 2

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num > 0 && num < 6)
{
    System.Console.WriteLine($"Рабочий день");
}
else if (num > 5 && num < 8) ;
{
    System.Console.WriteLine("Выходной день");
}
else (num < 1 && num > 7);
{
    System.Console.WriteLine("Вы ввели некорректное число");
}

// Этот вариант не рабочий, но я не понимаю почему.