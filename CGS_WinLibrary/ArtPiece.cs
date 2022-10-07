using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
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
            return $"{PieceID} {Title} {Year} {Value.ToString("N2")} {Estimate.ToString("N2")} {this.artistID} {this.curatorID} {this.status}";
        }
        public string display()
        {
            return $"\n\tPieceID: {PieceID}\n\tTitle: {Title}\n\tYear: {Year}\n\tPrice: {Value.ToString("N2")} \n\tEstimate: {Estimate.ToString("N2")} \n\tArtistID: {this.artistID} \n\tCurrtorID: {this.curatorID} \n\tStatus: {this.status}\n=====\n";
        }
        public string GetID()
        {
            return PieceID;
        }
        public void ChangeStatus(Status st)
        {
            if (Enum.IsDefined(typeof(Status), st))
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
