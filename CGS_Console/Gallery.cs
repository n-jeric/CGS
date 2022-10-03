using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    class Gallery
    {
        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        ArtPieces myArtPieces = new ArtPieces();

        public Gallery() { }

        #region Add
        private bool CuratorVerifier(string cID)
        {
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == cID)
                {
                    return true;
                }
            }
            return false;
        }
        public string AddCurator()
        {

            Console.WriteLine("Please enter CuratorID:");
            string curatorID = Console.ReadLine();

            if (curatorID.Length != 5)
            {
               return "Error. The curatorID should be 5 characters";
            }
            if (CuratorVerifier(curatorID) == true)
            {
               return "Error. This ID already exits";
            }
            Console.WriteLine("Please enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            string lastName = Console.ReadLine();
            if (firstName.Length + lastName.Length > 40)
            {
                return "Error. Name should be less than 40 characters";
            }
            myCurators.AddCurator(new Curator(curatorID, firstName, lastName));
            return $"Success! Curator {curatorID} added to the list";
        }
        private bool ArtistVarifier(string aID)
        {
            foreach (Artist art in myArtists)
            {
                if (art.GetID() == aID)
                {
                    return true;
                }
            }
            return false;
        }
        public string AddArtist()
        {
            Console.WriteLine("Please enter ArtistID:");
            string artistID = Console.ReadLine();

            if (artistID.Length != 5)
            {
                return "Error. The artistID should be 5 characters";
            }

            if (ArtistVarifier(artistID) == true)
            {
                return "Error. This ID already exists.";
            }
            Console.WriteLine("Please enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            string lastName = Console.ReadLine();

            if (firstName.Length + lastName.Length > 40)
            {
                return "Error. Name should be less than 40 characters";
            }
            myArtists.AddArtist(new Artist(artistID, firstName, lastName));
            return $"Success! Artist {artistID} added to the list";
        }
        private bool ArtPieceVarifier(string apID)
        {
            foreach (ArtPiece artP in myArtPieces)
            {
                if (artP.GetID() == apID)
                {
                    return true;
                }
            }
            return false;
        }
        public string AddPiece()
        {
            Console.WriteLine("Please enter ArtPieceID:");
            string artPieceID = Console.ReadLine();
            if (artPieceID.Length != 5)
            {
                return "Error. ArtPieceID should be 5 characters";
            }
            if (ArtPieceVarifier(artPieceID) == true)
            {
                return "Error. This ID already exits";
            }
            Console.WriteLine("Please enter title:");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter value:");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter ArtistID:");
            string artistID = Console.ReadLine();
            if (ArtistVarifier(artistID) == false)
            {
                return "Error. This ID does not exits";
            }
            Console.WriteLine("Please enter CuratorID:");
            string curatorID = Console.ReadLine();
            if (CuratorVerifier(curatorID) == false)
            {
                return "Error. This ID does not exits";
            }
            myArtPieces.AddPiece(new ArtPiece(artPieceID, title, year, value, artistID, curatorID));
            return $"Success! ArtPiece {artPieceID}: {title} added to inventory";
        }
        #endregion

        #region List
        public void ListCurators()
        {
            for (int i = 0; i < myCurators.Count; i++)
            {
                Console.WriteLine($"Curator #{i + 1}: {myCurators[i].toString()}");
            }
        }
        public void ListArtists()
        {
            for (int i = 0; i < myArtists.Count; i++)
            {
                Console.WriteLine($"Artist #{i + 1}: {myArtists[i].toString()}");
            }
        }
        public void ListPieces()
        {
            for (int i = 0; i < myArtPieces.Count; i++)
            {
                Console.WriteLine($"Art Piece #{i + 1}: {myArtPieces[i].toString()}");
            }
        }
        #endregion

    }
}
