using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    internal class Artist: Person
    {
        public string ArtistID { get; set; }

        public Artist(string artistID, string firstName, string lastName) : base(firstName, lastName)
        {
            ArtistID = artistID;
        }

        public string GetID()
        {
            return ArtistID;
        }
        public override string toString()
        {
            return $"{ArtistID} {base.toString()}";
        }
    }
}
