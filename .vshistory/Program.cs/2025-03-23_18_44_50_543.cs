/*
 * Programming 2 - Assignment 4 - Winter 2025 
 * Created by:  Elnara Kanybek 2474971
 * Tested by: Kevin S.
 * Relationship: Brother in law
 * Date: 20/03/2025
 * 
 * Description: To create a leaderboard that will store various info about the winners
 * of a game in descendig order. It will also allow to save the leaderboard to a desired 
 * file and load it back from a file wich supports persistent storage. After loading, the
 * leaderboard will be displayed including a redisplay if any changes are made to it.
 *   
 */




namespace Assignment4_Elnara
{
    internal class Program
    {
        // Define the struct to store winner's info
        struct Winner
        {
            public string name;
            public int score;
            public DateTime endTime;
            public int gamesPlayed;
            public int age;

        }
        static void Main(string[] args)
        {
            bool running = true; // variable to keep the program running
            int userChoice; // variable to store user input
            List <Winner> winnerList= new List<Winner>(); // create a list to store the leaderboard entries for each winner

            do {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Welcome to Programming 2 - Assignment 4 - Winter 2025");
                Console.WriteLine("Created by Elnara Kanybek 2474971 on 20/03/2025");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Please choose from below:" +
                    "\n 1 - Add winner to leaderboard" +
                    "\n 2 - Delete an entry from the leaderboard" +
                    "\n 3 - Save the leaderboard to a file" +
                    "\n 4 - Load the leaderboard from a file" +
                    "\n 5 - Clear the leaderboard" +
                    "\n 6 - Quit");
            } while (userChoice != 6); // while input not 6 keep displaying the menu

            bool successfulConversion = int.TryParse(Console.ReadLine(), out userChoice);  // get user input
            while (!successfulConversion) // check if the input is valid
            {
                Console.Write("Error, Invalid Input. Please choose from the menu options (1-6): "); // display error message
                successfulConversion = int.TryParse(Console.ReadLine(), out userChoice);
            }

            switch (userChoice)
            {
                case 1:
                    AddWinner(winnerList); // Add winner to leaderboard
                    break;
                case 2:
                    DeleteEntry(); // Delete an entry from the leaderboard
                    break;
                case 3:
                    SaveToFile();  // Save the leaderboard to a file
                    break;
                case 4:
                    LoadFromFile();  // Load the leaderboard from a file
                    break;
                case 5:
                    ClearLeaderboard();// Clear the leaderboard
                    break;
                case 6:
                    running = QuitProgram(); // Quit the program
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose from the menu options (1-6)");
                    break;
            }

            Console.ReadLine();
        }

        static void AddWinner(List< Winner> winnerList) 
        {
            bool successfulConversion; // variable to store the result of the conversion

            Console.Write("Enter the name of the winner: ");
            string playerName = Console.ReadLine(); // get the name of the winner
            while (string.IsNullOrEmpty(playerName) || !Regex.IsMatch(playerName, @"^[A-Za-z]+$")) // to make sure the input is a valid character
            {
                Console.Write("Invalid input. Name can't be null, empty or numerical. Please enter a valid name: "); // display according error message 
                playerName = Console.ReadLine();
            }

            Console.Write("Enter the score of {playerName}: ");
            successfulConversion = int.TryParse(Console.ReadLine(), out int playerScore);
            while (!successfulConversion || playerScore < 0 || playerScore > 1000000) // Max score is 1 000 000
            {
                Console.Write("Invalid input. Please enter a valid age: ");
                successfulConversion = int.TryParse(Console.ReadLine(), out playerScore);
            }

            Console.Write($"Enter the game end time of {playerName} in this format (hour:min): ");
            successfulConversion = DateTime.TryParse(Console.ReadLine(), out DateTime gameEndTime);
            while (!successfulConversion)
            {
                Console.Write("Invalid input. Please enter a valid game end time : ");
                successfulConversion = DateTime.TryParse(Console.ReadLine(), out gameEndTime);
            }

            Console.Write($"Enter the number of games played by {playerName} : ");
            successfulConversion = int.TryParse(Console.ReadLine(), out int gamesPlayed);
            while (!successfulConversion || playerScore < 0 || playerScore > 1000000) // Max of games played is 1 000 000
            {
                Console.Write("Invalid input. Please enter a valid number: ");
                successfulConversion = int.TryParse(Console.ReadLine(), out playerScore);
            }

            Console.Write($"Enter the age of {playerName}: ");
            successfulConversion = int.TryParse(Console.ReadLine(), out int playerAge);
            while (!successfulConversion || playerAge < 0 || playerAge > 130)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
                successfulConversion = int.TryParse(Console.ReadLine(), out playerAge);
            }
            winnerList.Add(); // add new winner info to the list
        }

        static void DeleteEntry()
        { 
        }

        static void SaveToFile()
        {
        }

        static void LoadFromFile()
        {
        }

        static void ClearLeaderboard()
        {
        }

        static void QuitProgram()
        {
        }
    }
