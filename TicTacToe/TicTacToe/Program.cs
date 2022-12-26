namespace TicTacTo
{
    class Program
    {


        private static string[,] arr = {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
        };


        // Check who plays
        private static bool isPlayingX = false;
        private static bool isPlayingO = false;


        static void Main(string[] args)
        {
            StartGame();
        }

        // Print the 2d Array named arr of type string
        public static void Board()
        {

            Console.WriteLine("    ");
            Console.WriteLine("---------------");
            Console.WriteLine($"| {arr[0, 0]} | {arr[0, 1]}  | {arr[0, 2]} |");
            Console.WriteLine("---------------");
            Console.WriteLine($"| {arr[1, 0]} | {arr[1, 1]}  | {arr[1, 2]} |");
            Console.WriteLine("---------------");
            Console.WriteLine($"| {arr[2, 0]} | {arr[2, 1]}  | {arr[2, 2]} |");
            Console.WriteLine("---------------");
        }

        // The player is asked if he wants to play Tic Tac Toe
        // In case he wants, the board will be rendered and is asked to choose x or o
        // otherwise the game is over
        public static void StartGame()
        {
            Console.WriteLine("Do you want to start the game Tic Tac Toe? Y/n");
            string? confirm = Console.ReadLine();
            if (confirm != null && confirm.ToUpper() == "Y")
            {

                StartGame();
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
        }

        // Ask the user to choose X or O to play with
        // In case of a different input, it will be asked to enter only  x or o
        public static string ChossePlayer()
        {
            Console.WriteLine("PlayerX will play with X and PlayerO will play with O. Please choose X or O!");

            string? choose = Console.ReadLine().ToUpper();
            switch (choose)
            {
                case "X":
                    {
                        Console.WriteLine("You chose to play with PlayerX.");
                        isPlayingX = true;

                        LogicalGame();
                        break;
                    }
                case "O":
                    {
                        Console.WriteLine("You chose to play with PlayerO.");
                        isPlayingO = true;

                        LogicalGame();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select only X or O");
                        ChossePlayer();
                        break;
                    }
            }

            return choose;
        }

        // As long as variable is false, method CheckAndGetNumber is called
        // If nr 1 is entered. This is stored in variable nr and case 1 is executed
        public static void LogicalGame()
        {
            bool won = false;

            // If counter = 9 means 9 valid cases without a winner
            int counter = 0;

            while (won != true)
            {
                int nr = CheckAndGetNumber();
                counter++;
                switch (nr)
                {
                    case 1:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[0, 0] != "O")
                                {
                                    arr[0, 0] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[0, 0] != "X")
                                {
                                    arr[0, 0] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 2:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[0, 1] != "O")
                                {
                                    arr[0, 1] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[0, 1] != "X")
                                {
                                    arr[0, 1] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 3:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[0, 2] != "O")
                                {
                                    arr[0, 2] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[0, 2] != "X")
                                {
                                    arr[0, 2] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 4:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[1, 0] != "O")
                                {
                                    arr[1, 0] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[1, 0] != "X")
                                {
                                    arr[1, 0] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 5:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[1, 1] != "O")
                                {
                                    arr[1, 1] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[1, 1] != "X")
                                {
                                    arr[1, 1] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 6:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[1, 2] != "O")
                                {
                                    arr[1, 2] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[1, 2] != "X")
                                {
                                    arr[1, 2] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 7:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[2, 0] != "O")
                                {
                                    arr[2, 0] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[2, 0] != "X")
                                {
                                    arr[2, 0] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 8:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[2, 1] != "O")
                                {
                                    arr[2, 1] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[2, 1] != "X")
                                {
                                    arr[2, 1] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                    case 9:
                        {
                            if (isPlayingX == true)
                            {
                                if (arr[2, 2] != "O")
                                {
                                    arr[2, 2] = "X";
                                    Xturn();
                                }
                                else
                                {

                                    IsTakenByO();
                                }



                            }
                            else
                            {
                                if (arr[2, 2] != "X")
                                {
                                    arr[2, 2] = "O";
                                    Oturn();
                                }
                                else
                                {
                                    IsTakenByX();
                                }



                            }
                            Board();
                            break;
                        }
                }
                won = Checker(arr);
                if (won == true || counter >=9)
                {
                    string res = Result(arr);
                    Console.WriteLine(res);
                    StartGame();
                }
            }

        }

        // Show whose turn it is
        public static void PrintTurnMsg()
        {
            if (isPlayingX == true)
            {
                Console.WriteLine("PlayerX's turn");
            }
            else
            {
                Console.WriteLine("PlayerO's turn");
            }
        }

        // The PlayerX or PlayerO is asked to enter a number.
        // Small number which is accepted is 1 and bigger is 9. Otherwise the player is asked againg
        public static int CheckAndGetNumber()
        {
            PrintTurnMsg();
            Console.WriteLine("Please enter a number 1 - 9 inclusive to place X or O");

            int getNumber;
            string? inputValue = Console.ReadLine();
            bool nr = int.TryParse(inputValue, out getNumber);
            if (!nr || getNumber < 1 || getNumber >= 10)
            {
                Console.WriteLine("Try to enter the correct value!");

                inputValue = Console.ReadLine();
                nr = int.TryParse(inputValue, out getNumber);
            }
            return getNumber;
        }

        // Check if the value at each index on the same row, column or on one of the diagonals has the same value  and 
        // return true
        public static bool Checker(string[,] board)
        {

            bool won = false;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    won = true;
                }

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    won = true;
                }


            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                won = true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                won = true;
            }

            return won;
        }

        // This method returns the winner or if it is a draw and store it in result variable 
        public static string Result(string[,] arr)
        {
            string result = "";
            bool check = Checker(arr);
            
            if (check == true)
            {

                // Check for horizontal
                if (arr[0, 0] == "X" && arr[0, 1] == "X" && arr[0, 2] == "X" ||

                    arr[1, 0] == "X" && arr[1, 1] == "X" && arr[1, 2] == "X" ||

                    arr[2, 0] == "X" && arr[2, 1] == "X" && arr[2, 2] == "X")
                {
                    result = "PlayerX Won!";

                }
                else if (arr[0, 0] == "O" && arr[0, 1] == "O" && arr[0, 2] == "O" ||

                    arr[1, 0] == "O" && arr[1, 1] == "O" && arr[1, 2] == "O" ||

                    arr[2, 0] == "O" && arr[2, 1] == "O" && arr[2, 2] == "O")
                {
                    result = "PlayesO Won!";
                }

                // Checks for vertical

                if (arr[0, 0] == "X" && arr[1, 0] == "X" && arr[2, 0] == "X" ||

                    arr[0, 1] == "X" && arr[1, 1] == "X" && arr[2, 1] == "X" ||

                    arr[0, 2] == "X" && arr[1, 2] == "X" && arr[2, 2] == "X")

                {
                    result = "PlayerX Won!";

                }
                else if (arr[0, 0] == "O" && arr[1, 0] == "O" && arr[2, 0] == "O" ||

                    arr[0, 1] == "O" && arr[1, 1] == "O" && arr[2, 1] == "O" ||

                    arr[0, 2] == "O" && arr[1, 2] == "O" && arr[2, 2] == "O")
                {
                    result = "PlayesO Won!";
                }

                // Checks for diagonals
                if (arr[0, 0] == "X" && arr[1, 1] == "X" && arr[2, 2] == "X")
                {
                    result = "PlayerX Won!";

                }
                else if (arr[0, 0] == "O" && arr[1, 1] == "O" && arr[2, 2] == "O")

                {
                    result = "PlayerO Won!";
                }

                if (arr[0, 2] == "X" && arr[1, 1] == "X" && arr[2, 0] == "X")
                {
                    result = "PlayerX Won!";

                }
                else if (arr[0, 2] == "O" && arr[1, 1] == "O" && arr[2, 0] == "O")
                {
                    result = "PlayerO Won!";
                }

            }
            else
            {
                result = "Draw";
            }

            return result;
        }

        // After PlayerX placed an X on the board, it will be PlayerO's turn
        public static bool Xturn()
        {
            isPlayingX = false;
            isPlayingO = true;

            return isPlayingO;
        }

        // After PlayerO placed an O on the board, it will be PlayerX's turn
        public static bool Oturn()
        {
            isPlayingX = true;
            isPlayingO = false;

            return isPlayingX;
        }

        // Check if an index from the baord is occupied with an O to prevent overwriting
        public static bool IsTakenByO()
        {
            isPlayingX = true;
            isPlayingO = false;
            Console.WriteLine("It is already taken by O");
            return isPlayingO;
        }

        // Check if an index from the baord is occupied with an X to prevent overwriting
        public static bool IsTakenByX()
        {
            isPlayingX = false;
            isPlayingO = true;
            Console.WriteLine("It is already taken by X");
            return isPlayingX;
        }

       
    }






}
