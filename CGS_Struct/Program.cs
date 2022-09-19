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

        static void Main(string[] args)
        {
           
        }
    }
}
