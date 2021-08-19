
using System;

namespace VideoConsoleProject
{
    public class ConsoleMenu
    {

        public void Start()
        {
            OpeningMessageMenu();
        }

        public void Print(string value)
        {
            Console.WriteLine(value);
        }

        public void OpeningMessageMenu()
        {
            Print(StringConstants.openingMessage);
        }
    }
}