using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    class Artists: CollectionBase
    {
        public void AddArtist(Artist artist)
        {
            List.Add(artist);
        }

        public Artist this[int index]
        {
            get => (Artist)List[index];
            set => List[index] = value;
        }
    }
}
