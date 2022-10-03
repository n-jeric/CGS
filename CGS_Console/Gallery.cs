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
            Console.WriteLine("Curators:\n");
            for (int i = 0; i < myCurators.Count; i++)
            {
                Console.WriteLine($"Curator #{i + 1}: {myCurators[i].toString()}");
            }
        }
        public void ListArtists()
        {
            Console.WriteLine("Artists:\n");
            for (int i = 0; i < myArtists.Count; i++)
            {
                Console.WriteLine($"Artist #{i + 1}: {myArtists[i].toString()}");
            }
        }
        public void ListPieces()
        {
            Console.WriteLine("ArtPieces:\n");
            for (int i = 0; i < myArtPieces.Count; i++)
            {
                Console.WriteLine($"Art Piece #{i + 1}: {myArtPieces[i].toString()}");
            }
        }
        #endregion

        public string SellPiece()
        {
            Console.WriteLine("Enter ID of ArtPiece being sold:");
            string pieceID = Console.ReadLine();

            if (ArtPieceVarifier(pieceID) == false)
            {
                return "Error. This ID does not exits";
            }
            
            foreach (ArtPiece ap in myArtPieces)
            {
                if (ap.GetID() == pieceID)
                {
                    //check status
                    if (ap.Status == Status.S)
                    {
                       return "Error. This piece is already sold";
                    }
                    Console.WriteLine("Enter sale price of ArtPiece");
                    double price = Convert.ToDouble(Console.ReadLine());

                    if (price <= ap.Value)
                    {
                        return"Error. Sale price is less than ArtPiece value.";
                    }
                    CuratorCommision(ap, price);
                }
            }
            return $"ArtPiece {pieceID} sold";
        }
        //method extracts the Curator ID assigned to the art piece using the Curator method GetID,
        //calls the ArtPiece’s ChangeStatus, PricePaid and CalculateComm methods and curator SetComm
        public void CuratorCommision(ArtPiece artPiece, double price)
        {
            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == artPiece.CuratorID)
                {
                    artPiece.ChangeStatus(Status.S);
                    artPiece.PriceSale(price);

                    cur.SetComm(artPiece.CalculateCommission(price));
                }
            }
        }

        public void ChageStat()
        {
            Console.WriteLine("Enter ID of ArtPiece to change status:");
            string pieceID = Console.ReadLine();

            foreach (ArtPiece ap in myArtPieces)
            {
                if (ap.GetID() == pieceID)
                {
                    Console.WriteLine("Enter status:");

                    if(Enum.TryParse(Console.ReadLine(), out Status status))
                    {
                        ap.ChangeStatus(status);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect status");
                    }
                }
            }
        }

    }
}
