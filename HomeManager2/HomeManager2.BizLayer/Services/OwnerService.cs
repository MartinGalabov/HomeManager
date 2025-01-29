using HomeManager.DataLayer.Interfaces;
using HomeManager.Models.DTO;
using HomeManager.Models.Request;
using System.Collections.Generic;

namespace HomeManager.BizLayer.Services
{
    internal class OwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public List<OwnerInfo> GetAllOwners()
        {
            return _ownerRepository.GetAllOwners();
        }

        public OwnerInfo GetOwnerByApartment(string apartmentNumber)
        {
            return _ownerRepository.GetOwnerByApartment(apartmentNumber);
        }

        public void AddOwner(OwnerInfo owner)
        {
            _ownerRepository.AddOwner(owner);
        }

        public void UpdateOwner(OwnerInfo owner)
        {
            _ownerRepository.UpdateOwner(owner);
        }

        public void DeleteOwner(string apartmentNumber)
        {
            _ownerRepository.DeleteOwner(apartmentNumber);
        }
    }
}