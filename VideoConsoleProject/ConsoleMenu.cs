
using System;

namespace VideoConsoleProject
{
    internal class ConsoleMenu
    {

        public void Start()
        {
            OpeningMessage();
        }
        
        public void OpeningMessage()
        {
            Print(StringConstants.OpeningMessage);
            Print(StringConstants.PressAKeyMessage);
            string keyPressed = Console.ReadLine();
            if (keyPressed.Contains(""))
                MenuLoop();
            {
                
            }

        }

        public void EnterMainMenu()
        {
            
        }

        private void MainMenu()
        {
            Clear();
            Print(String.Empty);
            Print(StringConstants.MainMenuMessage);
            Print(String.Empty);
            Print(String.Empty);
            Print(StringConstants.AddMovieMessage);
            Print(String.Empty);
            Print(StringConstants.LoadLibraryMessage);
            Print(String.Empty);
            Print(StringConstants.DeleteMovieMessage);
            Print(String.Empty);
            Print(StringConstants.SeachForMovieMessage);
        }
        
        private void MenuLoop()
        {
            int choice;
            while ((choice = MenuOptionSelect()) != 0)
            {
                if (choice == 1)
                {
                    AddMovie();
                } 
                else if (choice == 2)
                {
                    LoadLibrary();
                }
                else if (choice == 3)
                {
                    DeleteMovie();
                }
                else if (choice == 4)
                {
                    SearchMovie();
                }
            }
        }
        
        private int MenuOptionSelect()
        {
            MainMenu();
            EmptyLine();
            
            var userChoice = Console.ReadLine();
            int returnUserChoice;
            
            if (int.TryParse(userChoice, out returnUserChoice))
            {
                return returnUserChoice;
            }

            throw new InvalidOperationException();
        }

        private void AddMovie()
        {
            Clear();
            EmptyLine();
            
            Print(StringConstants.AddMovie);
            
            Print(StringConstants.AddMovieName);
            var MovieName = Console.ReadLine();
            
            Print(StringConstants.AddMovieGenre);
            var MovieGenre = Console.ReadLine();
            
            Print(StringConstants.AddMovieRating);
            var MovieRating = Console.ReadLine();
            
            Print($"{StringConstants.MovieAddSucces} \n Name: {MovieName} \n Genre: {MovieGenre} \n {MovieRating}");
            
            Console.ReadLine();
        }

        private void LoadLibrary()
        {
            Start();
        }

        private void DeleteMovie()
        {
            Start();
        }

        private void SearchMovie()
        {
            Start();
        }

        private void Print(string value)
        {
            Console.WriteLine(value);
        }

        private void Clear()
        {
            Console.Clear();
        }

        private void EmptyLine()
        {
            Console.WriteLine("\n");
        }
    }
}