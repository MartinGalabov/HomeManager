using HomeManager.BizLayer.Services;
using HomeManager.Models.DTO;
using HomeManager.DataLayer.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;
using HomeManager.Models.Request;

namespace HomeManager.Test
{
    public class BusinessServiceTest
    {
        private readonly BusinessService _businessService;
        private readonly Mock<IApartmentRepository> _mockApartmentRepository;
        private readonly Mock<IOwnerRepository> _mockOwnerRepository;

        public BusinessServiceTest()
        {
            _mockApartmentRepository = new Mock<IApartmentRepository>();
            _mockOwnerRepository = new Mock<IOwnerRepository>();

            _mockApartmentRepository.Setup(repo => repo.GetAllApartments()).Returns(GetSampleApartments());
            _mockApartmentRepository.Setup(repo => repo.GetApartmentByNumber(It.IsAny<string>())).Returns((string number) => GetSampleApartments().Find(a => a.Number == number));
            _mockOwnerRepository.Setup(repo => repo.GetAllOwners()).Returns(GetSampleOwners());

            _businessService = new BusinessService(_mockApartmentRepository.Object, _mockOwnerRepository.Object);
        }

        [Fact]
        public void GetAllApartments_ShouldReturnAllApartments()
        {
            var apartments = _businessService.GetAllApartments();
            Assert.Equal(3, apartments.Count);
        }

        [Fact]
        public void GetAllOwners_ShouldReturnAllOwners()
        {
            var owners = _businessService.GetAllOwners();
            Assert.Equal(2, owners.Count);
        }

        private List<Apartment> GetSampleApartments()
        {
            return new List<Apartment>
            {
                new Apartment { Number = "1", Status = "Occupied", Fee = "1000" },
                new Apartment { Number = "2", Status = "Free", Fee = "2000" },
                new Apartment { Number = "3", Status = "Occupied", Fee = "3000" }
            };
        }

        private List<OwnerInfo> GetSampleOwners()
        {
            return new List<OwnerInfo>
            {
                new OwnerInfo { Apartment = "1", Name = "John Doe", Phone = "1234567890" },
                new OwnerInfo { Apartment = "2", Name = "Jane Smith", Phone = "0987654321" }
            };
        }
    }
}