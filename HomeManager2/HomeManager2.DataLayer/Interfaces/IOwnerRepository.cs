using HomeManager.Models.Request;
using System.Collections.Generic;

namespace HomeManager.DataLayer.Interfaces
{
    public interface IOwnerRepository
    {
        List<OwnerInfo> GetAllOwners();
        OwnerInfo GetOwnerByApartment(string apartmentNumber);
        void AddOwner(OwnerInfo owner);
        void UpdateOwner(OwnerInfo owner);
        void DeleteOwner(string apartmentNumber);
    }
}