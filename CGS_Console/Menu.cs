using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    internal class Menu
    {

        public static void DisplayMenu(Gallery gal)
        {
            char ans = '0';
            do
            {
                Console.WriteLine("\n==========Menu=========");
                Console.WriteLine("[1] - Add Curator");
                Console.WriteLine("[2] - Add Artist");
                Console.WriteLine("[3] - Art Piece");
                Console.WriteLine("[4] - Display Curators");
                Console.WriteLine("[5] - Display Artists");
                Console.WriteLine("[6] - Display Art Pieces");
                Console.WriteLine("[7] - Sell Art Piece");
                Console.WriteLine("[0] - Exit");

                Console.Write("Please enter your choice: ");
                ans = Console.ReadLine()[0];
                Console.WriteLine();

                switch (ans)
                {
                    case '1':
                        Console.WriteLine(gal.AddCurator());
                        break;
                    case '2':
                        Console.WriteLine(gal.AddArtist());
                        break;
                    case '3':
                        Console.WriteLine(gal.AddPiece());
                        break;
                    case '4':
                        gal.ListCurators();
                        break;
                    case '5':
                        gal.ListArtists();
                        break;
                    case '6':
                        gal.ListPieces();
                        break;
                    case '7':
                        Console.WriteLine(gal.SellPiece());
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect entry. Please try again.");
                        break;
                }

            } while (ans != '0');
        }
    }
}
