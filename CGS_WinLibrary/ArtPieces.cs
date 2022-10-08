using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    class ArtPieces: CollectionBase
    {
        public void AddPiece(ArtPiece piece)
        {
            List.Add(piece);
        }

        public ArtPiece this[int index]
        {
            get => (ArtPiece)List[index];
            set => List[index] = value;
        }
    }
}
