using LadysmithProperties.Data;
using Microsoft.AspNetCore.Mvc;

namespace LadysmithProperties.Controllers
{
    public class AccommodationController:Controller
    {
        private readonly IAccommodationRepository _accommodationRepository;
        public AccommodationController(IAccommodationRepository accommodationRepository) 
        {
            _accommodationRepository = accommodationRepository;
        }
        public IActionResult Accommodations()
        {
            return View(_accommodationRepository.Accommodations);
        }
    }
}
