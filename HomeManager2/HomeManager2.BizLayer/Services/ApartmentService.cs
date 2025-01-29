using HomeManager.DataLayer.Interfaces;
using HomeManager.Models.DTO;
using System.Collections.Generic;

namespace HomeManager.BizLayer.Services
{
    internal class ApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public List<Apartment> GetAllApartments()
        {
            return _apartmentRepository.GetAllApartments();
        }

        public Apartment GetApartmentByNumber(string number)
        {
            return _apartmentRepository.GetApartmentByNumber(number);
        }

        public void AddApartment(Apartment apartment)
        {
            _apartmentRepository.AddApartment(apartment);
        }

        public void UpdateApartment(Apartment apartment)
        {
            _apartmentRepository.UpdateApartment(apartment);
        }

        public void DeleteApartment(string number)
        {
            _apartmentRepository.DeleteApartment(number);
        }
    }
}