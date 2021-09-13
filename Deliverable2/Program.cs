using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            bool againhello = true;
            bool againsup = true;
            bool againkenobi = true;
            do{
                Console.Write("What you you like to say the the bot?");
                string input = (Console.ReadLine());
                string lowerinput = input.ToLower();

                again = false;
               
                if (lowerinput == "bye")
                {
                        Console.WriteLine("Goodbye!");
                }
                else if (lowerinput == "hello")
                {
                    if(againhello)
                    {
                        Console.WriteLine("Hi good to see you.");
                        again = true;
                        againhello = false;
                    } else{
                        Console.WriteLine("I'm sorry but you have already said that");
                        again = true;
                    }
                }
                else if (lowerinput == "sup")
                {
                    if(againsup)
                    {
                        Console.WriteLine("I am good");
                        againsup = false;
                        again = true;
                    } else
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                        again = true;
                    }
                }
                else if (lowerinput == "hello there")
                {
                    if(againkenobi)
                    {
                        Console.WriteLine("General Kenobi");
                        againkenobi = false;
                        again = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                        again = true;
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry but I do not understand");
                    again = true;
                } 
            }while (again) ;
        }
    }
}
