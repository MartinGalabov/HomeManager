using HomeManager.BizLayer.Services;
using HomeManager.Models.DTO;
using HomeManager.Models.Request;
using HomeManager.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly BusinessService _businessService;
        private readonly RequestValidator _requestValidator;

        public BusinessController(BusinessService businessService, RequestValidator requestValidator)
        {
            _businessService = businessService;
            _requestValidator = requestValidator;
        }

        // Apartment related endpoint
        [HttpGet("apartments")]
        public ActionResult<List<Apartment>> GetAllApartments()
        {
            return Ok(_businessService.GetAllApartments());
        }

        // Owner related endpoint
        [HttpGet("owners")]
        public ActionResult<List<OwnerInfo>> GetAllOwners()
        {
            return Ok(_businessService.GetAllOwners());
        }
    }
}