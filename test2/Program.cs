using System;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    delegate void UI();

    class Program
    {
        // Объявляем событие
        public static event UI UserEvent;

        // Используем метод для запуска события
        public static void OnUserEvent()
        {
            UserEvent();
        }
        static void Main()
        {
            //MyEvent evt = new MyEvent();
            // Добавляем обработчик события
            UserEvent += UserInfoHandler;
            while (true)
            {
                Thread.Sleep(1000);

                

                // Запустим событие
                OnUserEvent();
            }

        }
        public static void UserInfoHandler()
        {
            Console.WriteLine(File.ReadAllText("test.txt"));
        }
    }
}