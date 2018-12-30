using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number_1 = 5;
                int number_2 = 0;
                int number_3 = number_1 / number_2; // деление на нуль ОШИБКА
                Console.WriteLine(number_3); 
            }
            catch (Exception ex) // общий класс Exception с переменной ex
            {
                Console.WriteLine($"Возникла ошибка...{ex.Message}"); // обращение к "пропертям"
                Console.WriteLine(ex.StackTrace); // определение МЕСТА ОШИБКИ
            }
            finally
            {
                Console.WriteLine("Приложение продолжает работу..."); // выводит в итоге продолжение
            }
            Console.ReadLine();
        }
    }
}
