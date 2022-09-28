using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    class Gallery
    {
        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        ArtPieces myArtPieces = new ArtPieces();

        public Gallery() { }

        public bool CuratorVerifier(string cID)
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
        public string AddCurator()
        {

            Console.WriteLine("Please enter CuratorID:");
            string curatorID = Console.ReadLine();

            if (curatorID.Length != 5)
            {
               return "Error. The curatorID should be 5 characters";
            }
            if (CuratorVerifier(curatorID) == true)
            {
               return "Error. This ID already exits";
            }
            Console.WriteLine("Please enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            string lastName = Console.ReadLine();
            if (firstName.Length + lastName.Length > 40)
            {
                return "Error. Name should be less than 40 characters";
            }
            myCurators.AddCurator(new Curator(curatorID, firstName, lastName));
            return $"Success! Curator {curatorID} added to the list";
        }
    }
}
