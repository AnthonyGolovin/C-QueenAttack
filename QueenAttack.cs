using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
 
 static void Main()
    {
        Console.WriteLine("Enter a X coordinate for queen");
        int queenx = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Y coordinate for queen");
        int queeny = int.Parse(Console.ReadLine());
        int [] queencoord = {queenx, queeny};

        Console.WriteLine("Enter a X coordinate for pawn");
        int pawnx = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Y coordinate for pawn");
        int pawny = int.Parse(Console.ReadLine());
        int [] pawncoord = {pawnx, pawny};
    
        if (queencoord[0] == pawncoord[0])
        {
            Console.WriteLine("The queen can get your pawn!");
        }
         else if (queencoord[1] == pawncoord[1])
        {
            Console.WriteLine("The queen can get your pawn!");
        }
        else if (queencoord[0] > pawncoord[0])
        {
            int difference = queencoord[0] - pawncoord[0];
            if (queencoord[1] - difference == pawncoord[1] || queencoord[1] + difference == pawncoord[1])
            {
                Console.WriteLine("The queen can get your pawn!");

            }
        }
        else if (pawncoord[0] > queencoord[0])
        {
            int difference = pawncoord[0] - queencoord[0];
            if (pawncoord[1] - difference == queencoord[1] || pawncoord[1] + difference == queencoord[1])
            {
                Console.WriteLine("The queen can get your pawn!");

            }
        }


       

  
    }
}
