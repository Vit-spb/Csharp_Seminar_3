using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
     int number = Math.Abs(Convert.ToInt32(N));
     int i = 1;
        while (i <= number)
        {
            Console.WriteLine($"{Math.Pow(i,3)} ");
            i++;
        }
    } 

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 3;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}