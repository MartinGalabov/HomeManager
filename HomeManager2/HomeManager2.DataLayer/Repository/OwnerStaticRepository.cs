using HomeManager.Models.Request;
using System.Collections.Generic;
using System.Linq;

namespace HomeManager.DataLayer.Repository
{
    internal class OwnerStaticRepository
    {
        private static List<OwnerInfo> _owners = new List<OwnerInfo>
        {
            new OwnerInfo { Apartment = "1", Name = "John Doe", Phone = "123-456-7890" },
            new OwnerInfo { Apartment = "2", Name = "Jane Smith", Phone = "987-654-3210" },
            new OwnerInfo { Apartment = "3", Name = "Alice Johnson", Phone = "555-555-5555" }
        };

        public List<OwnerInfo> GetAllOwners()
        {
            return _owners;
        }

        public OwnerInfo GetOwnerByApartment(string apartmentNumber)
        {
            return _owners.FirstOrDefault(o => o.Apartment == apartmentNumber);
        }

        public void AddOwner(OwnerInfo owner)
        {
            _owners.Add(owner);
        }

        public void UpdateOwner(OwnerInfo owner)
        {
            var existingOwner = GetOwnerByApartment(owner.Apartment);
            if (existingOwner != null)
            {
                existingOwner.Name = owner.Name;
                existingOwner.Phone = owner.Phone;
            }
        }

        public void DeleteOwner(string apartmentNumber)
        {
            var owner = GetOwnerByApartment(apartmentNumber);
            if (owner != null)
            {
                _owners.Remove(owner);
            }
        }
    }
}
