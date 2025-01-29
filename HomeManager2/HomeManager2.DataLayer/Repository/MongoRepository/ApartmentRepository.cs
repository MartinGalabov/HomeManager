using HomeManager.DataLayer.Interfaces;
using HomeManager.Models.DTO;
using HomeManager.Models.Request;
using MongoDB.Driver;
using System.Collections.Generic;

namespace HomeManager.DataLayer.Repository.MongoRepository
{
    internal class ApartmentRepository : IApartmentRepository
    {
        private readonly IMongoCollection<Apartment> _apartments;

        public ApartmentRepository(IMongoClient client)
        {
            var database = client.GetDatabase("HomeManagerDB");
            _apartments = database.GetCollection<Apartment>("Apartments");
        }

        public List<Apartment> GetAllApartments()
        {
            return _apartments.Find(apartment => true).ToList();
        }

        public Apartment GetApartmentByNumber(string apartmentNumber)
        {
            return _apartments.Find(apartment => apartment.Number == apartmentNumber).FirstOrDefault();
        }

        public void AddApartment(Apartment apartment)
        {
            _apartments.InsertOne(apartment);
        }

        public void UpdateApartment(Apartment apartment)
        {
            _apartments.ReplaceOne(a => a.Number == apartment.Number, apartment);
        }

        public void DeleteApartment(string apartmentNumber)
        {
            _apartments.DeleteOne(apartment => apartment.Number == apartmentNumber);
        }
    }
}