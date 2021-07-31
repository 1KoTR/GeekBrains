using System;

/* Чечулин Денис
 * 
 * 6. 
 * 
 * *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
 * 
 */

namespace Task_6
{
    public class ConsoleControls
    {
        #region Print

        public static void Print(string ms = "", bool newLine = true)
        {
            if (newLine)
                Console.WriteLine(ms);
            else
                Console.Write(ms);
        }

        public static void Print(string ms, int x, bool newLine = true)
        {
            Console.SetCursorPosition(Console.CursorLeft + x, Console.CursorTop);
            Print(ms, newLine);
        }

        public static void Print(string ms, int x, int y, bool newLine = true)
        {
            Console.SetCursorPosition(Console.CursorLeft + x, Console.CursorTop + y);
            Print(ms, newLine);
        }

        #endregion

        #region Pause

        public static void Pause()
        {
            Console.ReadKey(true);
        }

        public static void Pause(int sec)
        {
            Console.WriteLine();
            var pauseProc = System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = "cmd",
                    Arguments = $"/C TIMEOUT /t {sec} /nobreak > NUL",
                    UseShellExecute = false
                });
            pauseProc.WaitForExit();
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleControls.Print("Hello World!");

            ConsoleControls.Print("Пока!", 4);

            ConsoleControls.Pause();

            ConsoleControls.Print("Hi!", 10, 3);

            ConsoleControls.Pause(2);

            ConsoleControls.Print(":3");
        }


    }
}
