using Egitim.Business.Abstract;
using Egitim.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egitim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OkulController : ControllerBase
    {
        IOkulService okulServis;

        public OkulController(IOkulService okulServis)
        {
            this.okulServis = okulServis;
        }

        [HttpGet]
        [Route("okulListele")] //
        public IActionResult OkulListele()
        {
            try
            {
                return Ok(okulServis.List(null));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message});
            }
        }

        [HttpGet]
        [Route("okulGetir")] //
        public IActionResult OkulGetir(int id)
        {
            try
            {
                return Ok(okulServis.Get(c=>c.Id == id));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("okulEkle")]//
        public IActionResult OkulEkle([FromBody]Okul entity)
        {
            try
            {
                okulServis.Add(new Okul
                {
                    OkulAdi = entity.OkulAdi,
                    OkulAciklama = entity.OkulAciklama,
                    OkulPuan = entity.OkulPuan,
                    FotoBaglantisi = entity.FotoBaglantisi,
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("okulGuncelle")]//
        public IActionResult OkulGuncelle([FromBody] Okul entity)
        {
            try
            {
                okulServis.Update(new Okul
                {
                    Id = entity.Id,
                    OkulAdi = entity.OkulAdi,
                    OkulAciklama = entity.OkulAciklama,
                    OkulPuan = entity.OkulPuan,
                    FotoBaglantisi = entity.FotoBaglantisi,
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("okulSil")] //
        public IActionResult OkulSil([FromBody] Okul entity)
        {
            try
            {
                okulServis.Delete(new Okul
                {
                    Id = entity.Id,
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
