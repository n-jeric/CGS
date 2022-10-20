using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CGS_WinLibrary
{
    public class Gallery
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
            if (firstName.Length + lastName.Length > 40 || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return "Error! Names required and should be 40 chars or less";
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

        #region DataTable
        public DataTable ToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties();

            foreach(PropertyInfo property in props)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }
            foreach(T item in list)
            {
                DataRow row = dt.NewRow();
                foreach (var propInfo in props)
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        public DataTable CuratorDataTable()
        {
            List<Curator> list = myCurators.Cast<Curator>().ToList();

            DataTable cDT = ToDataTable(list);
            return cDT;
        }
        public DataTable ArtistDataTable()
        {
            List<Artist> list = myArtists.Cast<Artist>().ToList();

            DataTable aDT = ToDataTable(list);
            return aDT;
        }
        public DataTable ArtPieceDataTable()
        {
            List<ArtPiece> list = myArtPieces.Cast<ArtPiece>().ToList();

            DataTable apDT = ToDataTable(list);
            return apDT;
        }
        public DataTable ArtPiecesForSaleDataTable()
        {
            List<ArtPiece> list = new List<ArtPiece>();

            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.Status != Status.S)
                {
                    list.Add(piece);
                }
            }
            DataTable apsDT = ToDataTable(list);

            return apsDT;
        }
        public DataTable ArtPiecesForSaleDataTable(string apID)
        {
            List<ArtPiece> list = new List<ArtPiece>();

            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.GetID() == apID && piece.Status != Status.S)
                {
                    list.Add(piece);
                }
            }
            DataTable apsDT = ToDataTable(list);

            return apsDT;
        }
        #endregion


        #region Sell ArtPiece
        public (string cID, double cCom) CuratorCommision(string curID, double comBase)
        {
            string cID = "";
            double curComm = 0.0;

            foreach (Curator cur in myCurators)
            {
                if (cur.GetID() == curID)
                {
                    double startComm = cur.Commission;
                    cur.SetComm(comBase);
                    cID = cur.GetID();
                    curComm = cur.Commission - startComm;
                }
            }
            return (cID: cID, cCom: curComm);
        }
        public string SellArtPiece(string artpieceID, double price)
        {
            foreach (ArtPiece piece in myArtPieces)
            {
                if (piece.GetID() == artpieceID)
                {
                    if (piece.Status == Status.S)
                    {
                        return "Error. This ArtPiece is sold";
                    }
                    if (price < piece.Value)
                    {
                        return "Error! The entered price is below the value of the ArtPiece.";
                    }
                    piece.ChangeStatus(Status.S);
                    piece.PriceSale(price);

                    (string cID, double cComm) = CuratorCommision(piece.CuratorID, piece.CalculateCommission(price));

                    return $"Success! {artpieceID} \"{piece.Title}\" has been sold\nCurator {cID} assigned ${cComm:N2} commission";
                }
            }
            return "Error. This ArtPiece does not exist";
        }
        #endregion

        #region Write to File
        public string Write(string fPath, string textToFile)
        {
            try
            {
                using (StreamWriter textOut = new StreamWriter(fPath))
                {
                    textOut.WriteLine(textToFile);
                }
                return "OK";
            }
            catch (IOException ex)
            {
                return ex.Message.ToString();
            }
        }
        public string WriteCurator(string dirPath)
        {
            string msg = "";
            string filePath = dirPath + "Curator.txt";
            if (myCurators.Count != 0)
            {
                string textToFile = "";
                for (int i = 0; i < myCurators.Count; i++)
                {
                    textToFile += $"{myCurators[i].CuratorID},{myCurators[i].FirstName},{myCurators[i].LastName}\n";
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }
        public string WriteArtist(string dirPath)
        {
            string msg = "";
            string filePath = dirPath + "Artist.txt";
            if (myArtists.Count != 0)
            {
                string textToFile = "";
                for (int i = 0; i < myArtists.Count; i++)
                {
                    textToFile += $"{myArtists[i].ArtistID},{myArtists[i].FirstName},{myArtists[i].LastName}\n";
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }
        #endregion

    }
}
