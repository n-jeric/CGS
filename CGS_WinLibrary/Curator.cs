using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    internal class Curator: Person
    {
        const double COMMRATE = 0.25;
        public string CuratorID { get; set; }
        public double Commission { get; set; }

        public Curator(string curatorID, string firstName, string lastName) : base(firstName, lastName)
        {
            CuratorID = curatorID;
            Commission = 0.0;
        }
        public Curator(string curatorID, string firstName, string lastName, string comm) : base(firstName, lastName)
        {
            CuratorID = curatorID;
            Commission = double.Parse(comm);
        }
        public override string toString()
        {
            return $"{CuratorID} {base.toString()} {Commission}";
        }
        public string GetID()
        {
            return CuratorID;
        }
        //The SetComm method receives the amount eligible for commission for an art piece(this amount is determined by the CalculateComm method 
        //in ArtPiece). SetComm uses COMMRATE to calculate the 25% commission due and assigns it to the curator identified by the ArtPiece.
        public void SetComm(double comm)
        {
            Commission += (comm * COMMRATE);
        }
    }
}
