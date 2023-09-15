// No19 Напишите программу, которая принимает на вход пятизначное число и
// проверяет,является ли оно палиндромом.

using System;

public class Answer
{
    static bool IsPalindrome(int number){
        // Введите свое решение ниже
        if (number>99999||number<10000)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        else
        {
            int d1 = number / 10000;
            int d2 = (number / 1000)%10;
            
            int d3 = (number / 10)%10;
            int d4 = number%10;

            if (d1 == d4 && d2 == d3)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }    
    }
  
    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}