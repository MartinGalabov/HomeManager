using HomeManager.DataLayer.Interfaces;
using HomeManager.Models.DTO;
using HomeManager.Models.Request;
using System.Collections.Generic;

namespace HomeManager.BizLayer.Services
{
    public class BusinessService
    {
        private readonly ApartmentService _apartmentService;
        private readonly OwnerService _ownerService;

        public BusinessService(IApartmentRepository apartmentRepository, IOwnerRepository ownerRepository)
        {
            _apartmentService = new ApartmentService(apartmentRepository);
            _ownerService = new OwnerService(ownerRepository);
        }

        // Method from ApartmentService
        public List<Apartment> GetAllApartments()
        {
            return _apartmentService.GetAllApartments();
        }

        // Method from OwnerService
        public List<OwnerInfo> GetAllOwners()
        {
            return _ownerService.GetAllOwners();
        }
    }
}