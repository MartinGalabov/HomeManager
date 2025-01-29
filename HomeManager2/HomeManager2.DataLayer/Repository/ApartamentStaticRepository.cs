using HomeManager.Models.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HomeManager.DataLayer.Repository
{
    internal class ApartmentStaticRepository
    {
        private static List<Apartment> _apartments = new List<Apartment>
        {
            new Apartment { Number = "1", Status = "Rented", Fee = "1000" },
            new Apartment { Number = "2", Status = "Free", Fee = "2000" },
            new Apartment { Number = "3", Status = "Rented", Fee = "3000" }
        };

        public List<Apartment> GetAllApartments()
        {
            return _apartments;
        }

        public Apartment GetApartmentByNumber(string number)
        {
            return _apartments.FirstOrDefault(a => a.Number == number);
        }

        public void AddApartment(Apartment apartment)
        {
            _apartments.Add(apartment);
        }

        public void UpdateApartment(Apartment apartment)
        {
            var existingApartment = GetApartmentByNumber(apartment.Number);
            if (existingApartment != null)
            {
                existingApartment.Status = apartment.Status;
                existingApartment.Fee = apartment.Fee;
            }
        }

        public void DeleteApartment(string number)
        {
            var apartment = GetApartmentByNumber(number);
            if (apartment != null)
            {
                _apartments.Remove(apartment);
            }
        }
    }
}