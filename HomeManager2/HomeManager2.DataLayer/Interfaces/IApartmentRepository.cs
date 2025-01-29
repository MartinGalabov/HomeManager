using HomeManager.Models.DTO;
using System.Collections.Generic;

namespace HomeManager.DataLayer.Interfaces
{
    public interface IApartmentRepository
    {
        List<Apartment> GetAllApartments();
        Apartment GetApartmentByNumber(string number);
        void AddApartment(Apartment apartment);
        void UpdateApartment(Apartment apartment);
        void DeleteApartment(string number);
    }
}