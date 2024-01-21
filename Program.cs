using System;
// by : Amir wael
namespace GmaingXO
{
    class Program
    {
        public static void Logain()
        {
            Console.WriteLine("Enter Username");
            String username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            String password = Console.ReadLine();
            if (username == "Admin" && password == "Admin")
            {
              
                setfelid();
                Console.WriteLine("Succes Login");

            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Erorr Please Check username or password");

            }
        }

        static char[,] playField =
           {

              {'1','2','3'},  //Row 0
               {'4','5','6'},  //Row 1
               {'7','8','9'}   //Row 2

        };
        static char[,] playFieldInitial =
        {

              {'1','2','3'},  //Row 0
               {'4','5','6'},  //Row 1
               {'7','8','9'}   //Row 2

        };

        static int turn = 0;
        static void Main(string[] args)
        {
            Logain();
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;












            // setfelid();
            //  Console.ReadKey();

         
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXo(player, input);
                }


                else if (player == 1)
                {
                    player = 2;
                    EnterXo(player, input);
                }
                
               // setfelid();

                                 // check winning condition
                char[] playerwinerr = { 'X', 'O' };

                foreach (char playerwin in playerwinerr)
                {
                    if (((playField[0, 0] == playerwin) && (playField[0, 1] == playerwin) && (playField[0, 2] == playerwin))
                        || ((playField[1, 0] == playerwin) && (playField[1, 1] == playerwin) && (playField[1, 2] == playerwin))
                        || ((playField[2, 0] == playerwin) && (playField[2, 1] == playerwin) && (playField[2, 2] == playerwin))
                        || ((playField[0, 0] == playerwin) && (playField[1, 0] == playerwin) && (playField[2, 0] == playerwin))
                        || ((playField[0, 1] == playerwin) && (playField[1, 1] == playerwin) && (playField[2, 1] == playerwin))
                        || ((playField[0, 2] == playerwin) && (playField[1, 2] == playerwin) && (playField[2, 2] == playerwin))
                        || ((playField[0, 0] == playerwin) && (playField[1, 1] == playerwin) && (playField[2, 2] == playerwin))
                        || ((playField[0, 2] == playerwin) && (playField[1, 1] == playerwin) && (playField[2, 0] == playerwin))

                        )
                    {
                        if (playerwin == 'X')
                        {

                            Console.WriteLine("\n player 2 is win");
                        }
                        else
                        {
                            Console.WriteLine("\n player 1 is win");
                        }
                        Console.WriteLine(" Press  any Kay to Reset the Game  : ");
                        Console.ReadKey();
                        ResetFiled();
                        break;
                    }
                    else if (turn == 10)
                    {
                        Console.WriteLine("/Draw");
                        Console.WriteLine("Press any Key to Reset the Game");
                        Console.ReadKey();
                        ResetFiled();
                        break;
                    }





                }


                do
                {
                    Logain();
                    Console.WriteLine("\nplayer {0} : Choose your Filed : ", player);

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {

                        Console.WriteLine("Erorr Please Enter number");
                        Console.Read();
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);


            } while (true);











        }
        public static void ResetFiled()
        {
            char[,] playFieldInitial =
        {

              {'1','2','3'},  //Row 0
               {'4','5','6'},  //Row 1
               {'7','8','9'}   //Row 2

        };
            playField = playFieldInitial;
            setfelid();
            turn = 0;
        }
        public static void setfelid()
        {

            Console.Clear();
            //TODO replace numbers with variebles
            Console.WriteLine(" -------------------------------------------------------------------                                                @ Copy Right Ameer Wael");
            Console.WriteLine(" -------------------------------------------------------------------                                                                 ");


            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
            turn++;

        }
        public static void EnterXo(int player, int input)
        {
            char playersign = ' ';
            if (player == 1)
                playersign = 'X';
            else if (player == 2)
                playersign = 'O';

            //player1 turn
            {
                switch (input)
                {
                    case 1: playField[0, 0] = playersign; break;
                    case 2: playField[0, 1] = playersign; break;
                    case 3: playField[0, 2] = playersign; break;
                    case 4: playField[1, 0] = playersign; break;
                    case 5: playField[1, 1] = playersign; break;
                    case 6: playField[1, 2] = playersign; break;
                    case 7: playField[2, 0] = playersign; break;
                    case 8: playField[2, 1] = playersign; break;
                    case 9: playField[2, 2] = playersign; break;
                }

            }


            // @ Copy Right >> Amir wael
        }
    }
}


