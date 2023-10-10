using _10_API_HospialProject_Erdinc_.Contexts;
using _10_API_HospialProject_Erdinc_.DTOs;
using _10_API_HospialProject_Erdinc_.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _10_API_HospialProject_Erdinc_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HastaneController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HastaneController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            List<HastaneListDTO> hastaneler = _context.Hastaneler.Select(x =>
                    new HastaneListDTO
                    {
                        Id = x.Id,
                        HastaneAd = x.HastaneAd,
                        Adres = x.Adres,
                    }
                ).ToList();

            if (hastaneler.Count == 0)
                return NotFound();
            else
                return Ok(hastaneler);
        }

        [HttpGet("{id}")]
        public ActionResult<HastaneListDTO> Get(int id)
        {
            Hastane hastane = _context.Hastaneler.Find(id);
            if(hastane == null) 
                return NotFound();

            HastaneListDTO hastaneListDTO = new HastaneListDTO()
            {
                Id = hastane.Id,
                HastaneAd = hastane.HastaneAd,
                Adres = hastane.Adres,
            };

            return hastaneListDTO;
        }

        [HttpPost]
        public ActionResult Create([FromBody]HastaneCreateDTO hastaneCreateDTO)
        {
            try
            {
                Hastane hastane = new Hastane()
                {
                    HastaneAd = hastaneCreateDTO.HastaneAd,
                    Adres = hastaneCreateDTO.Adres
                };
                _context.Hastaneler.Add(hastane);
                if (_context.SaveChanges() > 0)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Update(HastaneListDTO hastaneListDTO)
        {
            try
            {
                Hastane hastane = _context.Hastaneler.Find(hastaneListDTO.Id);
                if (hastane == null)
                    return BadRequest();

                hastane.HastaneAd = hastaneListDTO.HastaneAd;
                hastane.Adres = hastaneListDTO.Adres;
                _context.Hastaneler.Update(hastane);
                if (_context.SaveChanges() > 0)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Hastane hastane=_context.Hastaneler.Find(id);
            if(hastane==null)
                return NotFound();
            try
            {
                _context.Hastaneler.Remove(hastane);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
