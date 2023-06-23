using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] field = { { '1', '2', '3' },{ '4', '5', '6' },{ '7', '8', '9' } };
            bool isPlayable = true;
            int checker = 0;

            int turn = 0;
            string choice = " ";
            

            while (isPlayable)
            {
                choice = " ";
                bool didSomethingChanged = false;
                Console.WriteLine($"   |   |   ");
                Console.WriteLine($" {field[0, 0]} | {field[0, 1]} | {field[0, 2]} ");
                Console.WriteLine($"___|___|___");
                Console.WriteLine($"   |   |   ");
                Console.WriteLine($" {field[1, 0]} | {field[1, 1]} | {field[1, 2]} ");
                Console.WriteLine($"___|___|___");
                Console.WriteLine($"   |   |   ");
                Console.WriteLine($" {field[2, 0]} | {field[2, 1]} | {field[2, 2]} ");
                Console.WriteLine($"   |   |   ");

                if (turn % 2 == 0)
                {
                    Console.WriteLine("X Player turn, pick field with number:");
                    choice = Console.ReadLine();

                    if (choice.Length!= 1) 
                    {
                        Console.WriteLine("You put wrong number");
                        turn--;
                        
                    }
                    else
                    {
                        for(int i=0; i < 3; i++)
                        {
                            for(int j = 0; j < 3; j++)
                            {
                                if (choice[0] == field[i,j]) 
                                {
                                    field[i, j] = 'X';
                                    didSomethingChanged = true;
                                }
                            }
                        }
                        if (didSomethingChanged == false)
                        {
                            Console.WriteLine("This field is already picked");
                            turn--;
                        }
                    }
                    

                }
                else
                {
                    Console.WriteLine("O Player turn, pick field with number:");
                    choice = Console.ReadLine();

                    if (choice.Length  != 1)
                    {
                        Console.WriteLine("You put wrong number");
                        turn--;
                        
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (choice[0] == field[i, j])
                                {
                                    field[i, j] = 'O';
                                    didSomethingChanged = true;
                                }
                            }
                            
                        }
                        if (didSomethingChanged == false)
                        {
                            Console.WriteLine("This field is already picked");
                            turn--;
                        }

                    }

                }

                

                for (int i = 0; i < 3; i++)
                {
                    if (field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2])
                    {
                        Console.WriteLine($"Player {field[i,0]} won!");
                        isPlayable = false; 
                    }

                    if (field[0, i] == field[1, i] && field[1, i] == field[2, i])
                    {
                        Console.WriteLine($"Player {field[0,i]} won!");
                        isPlayable = false; 
                        
                    }
                }

                if (field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2])
                {
                    Console.WriteLine($"Player {field[0, 0]} won!");
                    isPlayable = false; 
                }

                if (field[2, 0] == field[1, 1] && field[1, 1] == field[0, 2])
                {
                    Console.WriteLine($"Player {field[2, 0]} won!");
                    isPlayable = false; 
                }

                turn++;
                checker++;

                if (checker == 9 && isPlayable == true)
                {
                    Console.WriteLine("Tie!");
                    isPlayable= false;
                }
                
            }
            

            Console.ReadKey();
        }
    }
}
