using AutoMapper;
using CatsAPI.Data;
using CatsAPI.Dtos;
using CatsAPI.Models;
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

        [HttpGet("{id}", Name = "GetCatById")]
        public ActionResult<CatReadDto> GetCatById(int id)
        {
            Console.WriteLine("--> Getting cat with id = " + id);
            var cat = _repository.GetCatById(id);
            if(cat != null){
                return Ok(_mapper.Map<CatReadDto>(cat));
            }
            
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CatReadDto> CreateCat(CatCreateDto catCreateDto)
        {
            var catModel = _mapper.Map<Cat>(catCreateDto);
            _repository.CreateCat(catModel);
            _repository.SaveChanges();

            var catReadDto = _mapper.Map<CatReadDto>(catModel);

            return CreatedAtRoute(nameof(GetCatById), new { Id = catReadDto.Id}, catReadDto);
        }
    }
}