using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    internal class Gallery
    {
        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        ArtPieces myArtPieces = new ArtPieces();

        public Gallery() { }

        #region Verifier
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
        #endregion

        #region Add
        public string AddCurator(string curatorID, string firstName, string lastName)
        {
            if (curatorID.Length != 5)
            {
                return "Error..! The curator ID should be 5 chars.";
            }
            if (CuratorVerifier(curatorID) == true)
            {
                return "Error! This ID already exists!";
            }
            if (firstName.Length + lastName.Length > 40)
            {
                return "Error! Names should be 40 chars or less";
            }
            myCurators.AddCurator(new Curator(curatorID, firstName, lastName));
            return "Success! The curator added to the list";
        }
        public string AddArtist(string artistID, string firstName, string lastName)
        {
            if (artistID.Length != 5)
            {
                return "Error! The artist ID should be 5 chars.";
            }
            if (ArtistVarifier(artistID) == true)
            {
                return "Error! There exist this ID for another artist!";
            }
            if (firstName.Length + lastName.Length > 40)
            {
                return "Error...! Names should be less than 40 characters";
            }
            myArtists.AddArtist(new Artist(artistID, firstName, lastName));
            return "Success! The artist added to the list";
        }
        public string AddArtPiece(string artPieceID, string title, int year, double value, string artistID, string curatorID, Status status)
        {
            if (artPieceID.Length != 5)
            {
                return "Error! ID should be exactly 5 chars.";
            }
            if (ArtPieceVarifier(artPieceID))
            {
                return "Error! This ID already exists!";
            }
            if (CuratorVerifier(curatorID) == false || ArtistVarifier(artistID) == false)
            {
                return "Error! Either AristID or CuratorID is incorrect.";
            }
            myArtPieces.AddPiece(new ArtPiece(artPieceID, title, year, value, artistID, curatorID, status));
            return "ArtPiece has been successfully added to the list.";
        }
        #endregion

        #region List
        public string ListArtists()
        {
            string info = "";
            for (int i = 0; i < myArtists.Count; i++)
            {
                info += $"Artist #{i + 1}: {myArtists[i].toString()}\n";
            }
            return info;
        }
        public string ListCurators()
        {
            string info = "";
            for (int i = 0; i < myCurators.Count; i++)
            {
                info += $"Curator #{i + 1}: {myCurators[i].toString()}\n";

            }
            return info;
        }
        public string ListPieces()
        {
            string info = "";
            for (int i = 0; i < myArtPieces.Count; i++)
            {
                info += $"ArtPiece #{i + 1}: {myArtPieces[i].toString()}\n";
            }
            return info;
        }
        public string ListSalePieces()
        {
            string info = "";
            for (int i = 0; i < myArtPieces.Count; i++)
            {
                if (myArtPieces[i].Status != Status.S)
                {
                    info += $"ArtPiece #{i + 1}: {myArtPieces[i].toString()}\n";
                }
            }
            return info;
        }
        public string ListSalePieces(string apID)
        {
            string info = "";
            foreach (ArtPiece artPiece in myArtPieces)
            {
                if (artPiece.GetID() == apID && artPiece.Status != Status.S)
                {
                    info = artPiece.Display();
                }
                else
                {
                    info = "ArtPiece not available for sale";
                }
            }
            return info;
        }
        #endregion

    }
}
