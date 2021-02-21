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
    public class OgretmenController : ControllerBase
    {
        IOgretmenService ogretmenServis;

        public OgretmenController(IOgretmenService ogretmenServis)
        {
            this.ogretmenServis = ogretmenServis;
        }

        [HttpGet]
        [Route("tumOgretmenleriListele")]//
        public IActionResult TumOgretmenleriListele()
        {
            try
            {
                return Ok(ogretmenServis.List(null));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("ogretmenGetir")]//
        public IActionResult OgretmenListele(int id)
        {
            try
            {
                return Ok(ogretmenServis.Get(c=>c.Id == id));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("okulaAitOgretmenGetir")]//
        public IActionResult OkulaAitOgretmenListele(int id)
        {
            try
            {
                return Ok(ogretmenServis.List(c => c.OkulId == id));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("ogretmenEkle")]//
        public IActionResult OgretmenEkle([FromBody]Ogretmen entity)
        {
            try
            {
                ogretmenServis.Add(new Ogretmen
                {
                    OgretmenAdSoyad = entity.OgretmenAdSoyad,
                    OgretmenBrans = entity.OgretmenBrans,
                    OgretmenAciklama = entity.OgretmenAciklama,
                    OgretmenPuan = entity.OgretmenPuan,
                    FotoBaglantisi = entity.FotoBaglantisi,
                    OgretmenPozisyon = entity.OgretmenPozisyon,
                    OkulId = entity.OkulId
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("ogretmenGuncelle")] //
        public IActionResult OgretmenGuncelle([FromBody] Ogretmen entity)
        {
            try
            {
                ogretmenServis.Update(new Ogretmen
                {
                    Id = entity.Id,
                    OgretmenAdSoyad = entity.OgretmenAdSoyad,
                    OgretmenBrans = entity.OgretmenBrans,
                    OgretmenAciklama = entity.OgretmenAciklama,
                    OgretmenPuan = entity.OgretmenPuan,
                    FotoBaglantisi = entity.FotoBaglantisi,
                    OgretmenPozisyon = entity.OgretmenPozisyon,
                    OkulId = entity.OkulId
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("ogretmenSil")]
        public IActionResult OgretmenSil([FromBody] Ogretmen entity)
        {
            try
            {
                ogretmenServis.Delete(new Ogretmen
                {
                    Id = entity.Id
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
