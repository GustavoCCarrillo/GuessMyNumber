using System;

namespace GuessMyNumber
{
    class GuessMyNumberProgram
    {
        static void Main(string[] args)
        {
            ////Implement bisection algorithm
            Console.WriteLine("Welcome to! Lets play Guess My number.");
            Console.ReadLine();


            
            //Bisection_Search();


            //Guess my number, human plays
            //Bisection_Search_Human_Plays();


            ////Guess my number, computer plays
            //Bisection_Search_PC_Plays();
        }


        public static void Bisection_Search()
        {
            int[] oneToTen = new int[10];
            int min = 0;
            int max = oneToTen.Length - 1;
            Random r = new Random();
            for(int i = 0; i < max; i++)
            {
                oneToTen[i] = r.Next(min, max);
            }
            bool winner = false;

            try
            {
                while (winner == false) 
                {
                    Console.WriteLine("Guess a number from 1 - 10:");
                    int guessNumber = int.Parse(Console.ReadLine());
                    int mid = (min + max) / 2;

                    if (guessNumber == oneToTen[mid])
                    {
                        Console.WriteLine($"You won!");
                        winner = true;
                    }
                    else if (guessNumber < oneToTen[mid])
                    {
                        Console.WriteLine("You're guess is too low! Try again.");
                        max = mid;
                        
                    }
                    else
                    {
                        Console.WriteLine($"You're guess is too high! Try again.");
                        min = mid;
                        
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message} Try AGAIN!");
                Bisection_Search();
            }
        }



        public static void Bisection_Search_Human_Plays()
        {
            Console.WriteLine("Lets Play!.");

            int min = 1;
            int max = 1000;
            int attempts = 0;
            bool winner = false;
            Random numbers = new Random();
            int randNum = numbers.Next(min, max);

            try
            {
                while (winner == false)
                {
                    Console.WriteLine("Guess a number from 1 - 1000:");
                    int guessNumber = int.Parse(Console.ReadLine());
                 

 
                    if (guessNumber > randNum)
                    {
                        Console.WriteLine($"You're guess is too high! Try again.");
                        min = randNum;
                        attempts++;
                        Console.WriteLine($"Attempts: {attempts}");

                    }
                    else if (guessNumber < randNum)
                    {
                        Console.WriteLine("You're guess is too low! Try again.");
                        max = randNum;
                        attempts++;
                        Console.WriteLine($"Attempts: {attempts}");
                    }
                    else
                    {
                        Console.WriteLine("You won! on your " + "#"+attempts+" attempt!" );
                        winner = true;
                    }
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Try AGAIN!");
                Bisection_Search_Human_Plays();
            }
        }





        public static void Bisection_Search_PC_Plays()
        {
            int[] numbers = new int[100];
            int min = 1;
            int max = numbers.Length;
            
            Random randNumbers = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNumbers.Next(min, max);
                
            }

          
            int attempts = 0;
            bool winner = false;

            //PC talking to human
            Console.WriteLine("Hey Human! Think of an integer from 1 - 100.");
            Console.WriteLine("I'll try and guess what it is =)");
            Console.WriteLine("When ready, press any key..");
            Console.ReadLine();

            try
            {
                while (winner == false)
                {
                GuessAgain:

                    int mid = (min + max) / 2;
                    int numberGuess = mid;
                    attempts++;

                    //PC talking to human
                    Console.WriteLine("I'm thinking of the number " + numberGuess);
                    Console.WriteLine("Did I get it??!!");
                    Console.WriteLine("Or is your number higher than " + numberGuess + "?");
                    Console.WriteLine("maybe lower than " + numberGuess + "?");
                    Console.WriteLine();

                    string myAnswer = Console.ReadLine();
                    myAnswer.ToLower();


                    if (myAnswer == "higher" || myAnswer == "high" || myAnswer == "hi" || myAnswer == "h")
                    {
                        min = numberGuess;
                    }
                    else if (myAnswer == "lower" || myAnswer == "low" || myAnswer == "lo" || myAnswer == "l")
                    {
                        max = numberGuess;
                    }
                    else if (myAnswer == "yes" || myAnswer == "y" || myAnswer == "yea" || myAnswer == "yee")
                    {
                        Console.WriteLine("Yay! I won! and on my " + "#"+attempts + " attempt");
                        winner = true;
                    }
                    else
                    {
                        Console.WriteLine("Ooopss.. I'm sorry I didn't understand your answer.");
                        Console.WriteLine("Please enter higher or lower");
                        Console.WriteLine("Lets try this again!");
                        goto GuessAgain;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Try AGAIN!");
                Bisection_Search_PC_Plays();
            }
        }



    }
}

