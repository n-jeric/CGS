using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    class ArtPiece
    {
        Status status = Status.D;
        string artistID;
        string curatorID;

        public string PieceID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Value { get; set; }
        public double Estimate { get; set; }
        public Status Status { get => status; set => status = value; }
        public string ArtistID { get => artistID; set => artistID = value; }
        public string CuratorID { get => curatorID; set => curatorID = value; }

        public ArtPiece(string pieceID, string title, int year, double value, string artistID, string curatorID)
        {
            PieceID = pieceID;
            Title = title;
            Year = year;
            Value = value;
            Estimate = 0.0; //The constructor does not receive the Estimate (price sold) or the status. Set the default for price to 0.
            this.artistID = artistID;
            this.curatorID = curatorID;
        }

        public string toString()
        {
            return $"\npieceID: {PieceID}\nTitle: {Title}\nYear: {Year}\nPrice: {Value.ToString()} \nEstimate: {Estimate.ToString()} \nArtistID: {this.artistID} \nCurrtorID: {this.curatorID} \nStatus: {this.status}\n========================\n";
        }
        public string GetID()
        {
            return PieceID;
        }
        public void ChangeStatus(Status st) //The ChangeStatus method changes the status to ‘S’ when an art piece is sold.
        {
            if(Enum.IsDefined(typeof(Status), st))
            {
                this.status = st;
            }
            else
            {
                Console.WriteLine("Status entered not valid.");
            }
        }
        public void PriceSale(double price)
        {
            Estimate = price;
        }
        //The CalculateCommission method receives the sale price(Estimate). It returns 50% of
        //the difference between the original value and the sale price. This value is sent to the SetComm method in the curator instance.
        public double CalculateCommission(double price)
        {
            return (price - Value) * .50;
        }
        
    }
}
