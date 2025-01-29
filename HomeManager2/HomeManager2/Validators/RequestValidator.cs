using HomeManager.Models.DTO;
using HomeManager.Models.Request;
using System;

namespace HomeManager.Validators
{
    public class RequestValidator
    {
        public bool ValidateApartment(Apartment apartment, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(apartment.Number))
            {
                errorMessage = "Apartment number is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(apartment.Status))
            {
                errorMessage = "Apartment status is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(apartment.Fee) || !decimal.TryParse(apartment.Fee, out _))
            {
                errorMessage = "Valid apartment fee is required.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateOwnerInfo(OwnerInfo ownerInfo, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(ownerInfo.Apartment))
            {
                errorMessage = "Apartment number is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ownerInfo.Name))
            {
                errorMessage = "Owner name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ownerInfo.Phone))
            {
                errorMessage = "Owner phone number is required.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}