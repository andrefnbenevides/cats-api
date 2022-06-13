using AutoMapper;
using CatsAPI.Data;
using CatsAPI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CatsAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly ICatRepo _repository;
        private readonly IMapper _mapper;

        public CatsController(ICatRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CatReadDto>> GetCats()
        {
            Console.WriteLine("--> Getting cats...");
            var cats = _repository.GetAllCats();
            return Ok(_mapper.Map<IEnumerable<CatReadDto>>(cats));
        }
    }
}