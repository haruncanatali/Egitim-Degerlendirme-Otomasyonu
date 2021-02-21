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
    public class OkulYorumController : ControllerBase
    {
        IOkulYorumService okulYorumServis;

        public OkulYorumController(IOkulYorumService okulYorumServis)
        {
            this.okulYorumServis = okulYorumServis;
        }

        [HttpGet]
        [Route("yorumListele")] // 
        public IActionResult OkulYorumlariListele()
        {
            try
            {
                return Ok(okulYorumServis.List(null));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("okulaAitYorumlariListele")] // 
        public IActionResult OkulaAitYorumlariGetir(int id)
        {
            try
            {
                return Ok(okulYorumServis.List(c => c.OkulId == id));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("yorumEkle")]//
        public IActionResult YorumEkle([FromBody]OkulYorum entity)
        {
            try
            {
                okulYorumServis.Add(new OkulYorum
                {
                    Ad = entity.Ad,
                    Soyad = entity.Soyad,
                    Mail = entity.Mail,
                    YorumIcerik = entity.YorumIcerik,
                    Puan = entity.Puan,
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
        [Route("yorumGuncelle")]//
        public IActionResult YorumGuncelle([FromBody] OkulYorum entity)
        {
            try
            {
                okulYorumServis.Update(new OkulYorum
                {
                    Id = entity.Id,
                    Ad = entity.Ad,
                    Soyad = entity.Soyad,
                    Mail = entity.Mail,
                    YorumIcerik = entity.YorumIcerik,
                    Puan = entity.Puan,
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
        [Route("yorumSil")]//
        public IActionResult YorumSil([FromBody] OkulYorum entity)
        {
            try
            {
                okulYorumServis.Delete(new OkulYorum
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
