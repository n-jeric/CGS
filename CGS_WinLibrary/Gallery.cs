using System;
using System.Collections.Generic;
using System.Linq;
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



}
