using Microsoft.AspNetCore.Mvc;
using ShelterReport1.Model;
using ShelterReport1.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShelterReport1.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MonkeyController : ControllerBase
    {
        private IMonkeyRepository _monkeyRepository;

        public MonkeyController(IMonkeyRepository monkeyRepository)
        {
            _monkeyRepository = monkeyRepository;
        }
        // GET: api/<MonkeyController>
        [HttpGet]
        [Route("/")]
        public IEnumerable<SpeciesReport> Get()
        {
            return _monkeyRepository.GetSpeciesReport();
        }
       
    }
}
