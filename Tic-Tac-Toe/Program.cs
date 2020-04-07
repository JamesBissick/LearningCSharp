using System;

namespace Tic_Tac_Toe {
    
    class Program {

        enum States {
            Empty, // Default
            Circle,
            Cross
        }
        
        public static String ANSI_RESET = "\u001B[0m";
        public static String ANSI_YELLOW = "\u001B[32m";
        public static String ANSI_BLUE = "\u001B[34m";

        private static States[,] grid; // 3 * 3 cases
        private static Random generator;

        static void Main(string[] args) {
            
            // Welcome message
            Console.WriteLine("Let's play Tic Tac Toe!");
            // Initialise variables
            bool end = false;
            grid = new States[3, 3];
            int emptyBox = 9;
            generator = new Random();
            
            // Display grid
            DisplayGrid();
            // Main loop
            do {
                // User turn
                UserChooseABox();
                emptyBox--;
                // Display grid
                DisplayGrid();
                // User Win check?
                bool win = WinCheck(States.Cross);
                if (win) {
                    end = true;
                    Console.WriteLine("🎉 Congrats! You've won!");
                }
                // CPU turn
                if (!end && emptyBox > 0) {
                    CPUChooseBox();
                    emptyBox--;
                    
                    // Display grid
                    Console.WriteLine("CPU has played! It's your turn.");
                    DisplayGrid();
                    // CPU Win check?
                    if (WinCheck(States.Circle)) {
                        end = true;
                        Console.WriteLine("💢 Darn it! CPU has won!");
                    }
                }
                
                // Tie!
                if (!win) {
                    if (emptyBox == 0) {
                        end = true;
                        Console.WriteLine("It's a tie!");
                    }
                }
                
            } while (!end);
            // End game
            Console.WriteLine("Enter a key to quit...");
            Console.ReadKey();
        }

        private static bool WinCheck(States state) {
            // Line wins
            for (int line = 0; line < 3; line++) {
                if (grid[line, 0] == state && grid[line, 1] == state && grid[line, 2] == state) {
                    return true;
                }
            }
            // Col wins
            for (int col = 0; col < 3; col++) {
                if (grid[0, col] == state && grid[1, col] == state && grid[2, col] == state) {
                    return true;
                }
            }
            // Diagonal wins
            if (grid[0, 0] == state && grid[1, 1] == state && grid[2, 2] == state) {
                return true;
            }
            if (grid[2, 0] == state && grid[1, 1] == state && grid[0, 2] == state) {
                return true;
            }
            // By default, no win
            return false;
        }

        private static void CPUChooseBox() {
            // Loop until correct choice
            bool correctChoice = false;
            do {
                // Random coordonates
                int line = generator.Next(0, 3);
                int col = generator.Next(0, 3);
                if (grid[line, col] == States.Empty) {
                    grid[line, col] = States.Circle;
                    correctChoice = true;
                }
            } while (!correctChoice);
        }

        /// <summary>
        /// Allows user to choose a box, that has to be free and put a cross
        /// </summary>
        private static void UserChooseABox() {
            // Loop until correct choice
            bool correctChoice = false;
            do {
                // message
                Console.WriteLine("Choose a box:");
                // Get answer
                String answer = Console.ReadLine();
                int choice;
                // Convert to Int
                if (int.TryParse(answer, out choice) && choice >= 0 && choice <= 8) {
                    // Empty box?
                    int line = choice / 3;
                    int col = choice % 3;
                    if (grid[line, col] == States.Empty) {
                        // Choice correct, validate
                        grid[line, col] = States.Cross;
                        correctChoice = true;
                    }
                }
                else {
                    Console.WriteLine("Please enter a correct number.");
                }
            } while (!correctChoice);
        }

        private static void DisplayGrid() {
            String gridLayout = "\n";
            gridLayout += "-------------\n";
            // For each lines
            for (int line = 0; line < 3; line++) {
                gridLayout += "| ";
                // For each column
                for (int col = 0; col < 3; col++) {
                    switch (grid[line, col]) {
                        case States.Empty :
                            gridLayout += line * 3 + col;
                            break;
                        case States.Cross :
                            gridLayout += ANSI_BLUE + "X" + ANSI_RESET;
                            break;
                        case States.Circle :
                            gridLayout += ANSI_YELLOW + "O" + ANSI_RESET;
                            break;
                    }

                    gridLayout += " | ";
                }
                gridLayout += "\n-------------\n";
            }
            Console.WriteLine(gridLayout);
        }
    }
}