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
            // если есть возможность изначально проверять через if...else, то лучше так, более опитимизированно получится!!!
            //try
            //{
            //    int number_1 = 5;
            //    int number_2 = 0;
            //    int number_3 = number_1 / number_2; // деление на нуль ОШИБКА
            //    if (number_2 == 0)
            //    {
            //        throw new Exception("На ноль делить нельзя!!!");
            //    }
            //    Console.WriteLine(number_3); 
            //}
            //catch (NullReferenceException ex) // специальный класс NullReferenceException с переменной ex
            //{
            //    Console.WriteLine($"Возникла ошибка...{ex.Message}"); 
            //    Console.WriteLine(ex.StackTrace); 
            //}
            //catch (Exception ex) // общий класс Exception с переменной ex
            //{
            //    Console.WriteLine($"Возникла ошибка...{ex.Message}"); // обращение к "пропертям"
            //    /*Console.WriteLine(ex.StackTrace);*/ // определение МЕСТА ОШИБКИ
            //}
            //finally
            //{
            //    Console.WriteLine("Приложение продолжает работу..."); // выводит в итоге продолжение
            //}
            try
            {
                Console.WriteLine("Введите строку менее 6 символов");
                string str = Console.ReadLine();
                if (str.Length > 6)
                {
                    throw new Exception("В Вашей строке более 6 символов"); // самостоятельная генерация исключения с текстом
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
