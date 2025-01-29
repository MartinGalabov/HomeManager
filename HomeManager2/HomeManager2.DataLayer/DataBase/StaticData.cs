using HomeManager.Models.DTO;

namespace HomeManager.DataLayer.DataBase
{
    internal static class StaticData
    {

        public static List<Apartment> Apartments = new List<Apartment>
        {
            new Apartment
            {
                Number = "1", Status = "Rented", Fee = "1000"
            },

            new Apartment
            {
                Number = "2", Status = "Free", Fee = "2000"
            },

            new Apartment
            {
                Number = "3", Status = "Rented", Fee = "3000"
            },
        };
    }
}