using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Struct
{
    internal class Program
    {
        #region Structures
        struct Person
        {
            public string fName;
            public string lName;
        }
        struct Curator
        {
            public string curatorID;
            public Person p0;
            public double commision;
        }
        struct Artist
        {
            public string artistID;
            public Person p0;
        }
        struct ArtPiece
        {
            public string artpieceID;
            public string curatorID;
            public string artistID;
            public string title;
            public int year;
            public double value;
            public double estimate;
            public char status;
        }
        #endregion

        #region Array & Index
        static Curator[] myCurators = new Curator[10];
        static Artist[] myArtists = new Artist[10];
        static ArtPiece[] myArtPieces = new ArtPiece[10];

        static int index_curator = 0;
        static int index_artist = 0;
        static int index_ArtPiece = 0;
        #endregion

        #region Verifier
        static bool curatorVerifier(string cID)
        {
            for (int i = 0; i < index_curator; i++)
            {
                if (myCurators[i].curatorID == cID)
                {
                    return true;
                }
            }
            return false;
        }
        static bool artistVerifier(string aID)
        {
            for (int i = 0; i < index_artist; i++)
            {
                if (myArtists[i].artistID == aID)
                {
                    return true;
                }
            }
            return false;
        }
        static bool artPieceVerifier(string apID)
        {

            for (int i = 0; i < index_ArtPiece; i++)
            {
                if (myArtPieces[i].artpieceID == apID)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Add
        static void AddCurator()
        {
            Console.Write("Please enter CuratorID: ");
            string curatorID = Console.ReadLine();
            if (curatorID.Length != 5)
            {
                Console.WriteLine("Error..! The curator should be 5 chars.");
            }
            else
            {
                if (curatorVerifier(curatorID) == true)
                {
                    Console.WriteLine("Error! This ID is already assigned to another curator!");
                }
                else
                {
                    Console.Write("Please enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Please enter last name: ");
                    string lastName = Console.ReadLine();
                    if (firstName.Length + lastName.Length > 40)
                    {
                        Console.WriteLine("Error! Names should be less than 40 chars");
                    }
                    else
                    {
                        myCurators[index_curator].curatorID = curatorID;
                        myCurators[index_curator].p0.fName = firstName;
                        myCurators[index_curator].p0.lName = lastName;
                        myCurators[index_curator].commision = 0.0;
                        index_curator++;
                        Console.WriteLine("Success! Curator added");
                        Console.WriteLine("==========================");
                    }
                }
            }
        }
        static void AddArtist()
        {
            Console.Write("Please enter ArtistID: ");
            string artistID = Console.ReadLine();
            if (artistID.Length != 5)
            {
                Console.WriteLine("Error..! The ArtistID should be 5 chars.");
            }
            else
            {
                if (artistVerifier(artistID) == true)
                {
                    Console.WriteLine("Error! This ID is already assigned to another artist!");
                }
                else
                {
                    Console.Write("Please enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Please enter last name: ");
                    string lastName = Console.ReadLine();
                    if (firstName.Length + lastName.Length > 40)
                    {
                        Console.WriteLine("Error! Names should be less than 40 chars");
                    }
                    else
                    {
                        myArtists[index_artist].artistID = artistID;
                        myArtists[index_artist].p0.lName = lastName;
                        myArtists[index_artist].p0.fName = firstName;
                        index_artist++;
                        Console.WriteLine("Success! Artist added");
                        Console.WriteLine("==========================");
                    }
                }
            }
        }
        static void AddArtPiece()
        {
            Console.Write("Please enter the ArtpieceId: ");
            string artPieceID = Console.ReadLine();
            if (artPieceID.Length != 5)
            {
                Console.WriteLine("Error..! Art Piece ID should be 5 chars.");
            }
            else
            {
                if (artPieceVerifier(artPieceID) == true)
                {
                    Console.WriteLine("Error! This ID is already assigned to another art piece!");
                }
                else
                {

                    Console.Write("Please enter CuratorID: ");
                    string curatorID = Console.ReadLine();
                    Console.Write("Please enter ArtistID: ");
                    string artistID = Console.ReadLine();
                    if (curatorVerifier(curatorID) == false || artistVerifier(artistID) == false)
                    {
                        Console.WriteLine("Error! Either AristID or CuratorID is incorrect.");
                    }
                    else
                    {
                        Console.Write("Please enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Please enter year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());

                        myArtPieces[index_ArtPiece].artpieceID = artPieceID;
                        myArtPieces[index_ArtPiece].artistID = artistID;
                        myArtPieces[index_ArtPiece].curatorID = curatorID;
                        myArtPieces[index_ArtPiece].title = title;
                        myArtPieces[index_ArtPiece].year = year;
                        myArtPieces[index_ArtPiece].value = value;
                        myArtPieces[index_ArtPiece].status = 'D';
                        index_ArtPiece++;
                        Console.WriteLine("Artpiece has been successfully added.");
                    }
                }
            }
        }
        #endregion



        static void Main(string[] args)
        {
           
        }
    }
}
