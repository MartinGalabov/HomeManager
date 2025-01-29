using HomeManager.Models.Request;
using MongoDB.Driver;
using System.Collections.Generic;

namespace HomeManager.DataLayer.Repository.MongoRepository
{
    internal class OwnerRepository
    {
        private readonly IMongoCollection<OwnerInfo> _owners;

        public OwnerRepository()
        {
            var client = new MongoClient("your_connection_string");
            var database = client.GetDatabase("HomeManagerDB");
            _owners = database.GetCollection<OwnerInfo>("Owners");
        }

        public List<OwnerInfo> GetAllOwners()
        {
            return _owners.Find(owner => true).ToList();
        }

        public OwnerInfo GetOwnerByApartment(string apartmentNumber)
        {
            return _owners.Find(owner => owner.Apartment == apartmentNumber).FirstOrDefault();
        }

        public void AddOwner(OwnerInfo owner)
        {
            _owners.InsertOne(owner);
        }

        public void UpdateOwner(OwnerInfo owner)
        {
            _owners.ReplaceOne(o => o.Apartment == owner.Apartment, owner);
        }

        public void DeleteOwner(string apartmentNumber)
        {
            _owners.DeleteOne(owner => owner.Apartment == apartmentNumber);
        }
    }
}
