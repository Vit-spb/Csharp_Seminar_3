// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.


using System;
using System.ComponentModel;

public class Answer
{
    static bool IsPalindrome(int number)
    
    {
      // Введите свое решение ниже
//----------------------------------------------------------------------
 string valSt = number.ToString();
  if (valSt.Length != 5)
  {
    Console.WriteLine("Число не пятизначное");
    return false;
  }
  if (valSt[0] == valSt[4] && valSt[1] == valSt[3])
  {
    return true;
  }
  return false;
    }
//------------------------------------------------------------------------
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 2343221;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
