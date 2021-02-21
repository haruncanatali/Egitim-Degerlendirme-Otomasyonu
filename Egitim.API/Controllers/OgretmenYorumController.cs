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
    public class OgretmenYorumController : ControllerBase
    {
        IOgretmenYorumService ogretmenYorumServis;

        public OgretmenYorumController(IOgretmenYorumService ogretmenYorumServis)
        {
            this.ogretmenYorumServis = ogretmenYorumServis;
        }

        [HttpGet]
        [Route("yorumListele")] //
        public IActionResult OgretmenYorumlariListele()
        {
            try
            {
                return Ok(ogretmenYorumServis.List(null));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("ogretmeneAitYorumlariListele")] //
        public IActionResult OgretmeneAitYorumlariGetir(int id)
        {
            try
            {
                return Ok(ogretmenYorumServis.List(c => c.OgretmenId == id));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("yorumEkle")]
        public IActionResult YorumEkle([FromBody] OgretmenYorum entity)
        {
            try
            {
                ogretmenYorumServis.Add(new OgretmenYorum
                {
                    Ad = entity.Ad,
                    Soyad = entity.Soyad,
                    Mail = entity.Mail,
                    YorumIcerik = entity.YorumIcerik,
                    Puan = entity.Puan,
                    OgretmenId = entity.OgretmenId
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("yorumGuncelle")]
        public IActionResult YorumGuncelle([FromBody] OgretmenYorum entity)
        {
            try
            {
                ogretmenYorumServis.Update(new OgretmenYorum
                {
                    Id = entity.Id,
                    Ad = entity.Ad,
                    Soyad = entity.Soyad,
                    Mail = entity.Mail,
                    YorumIcerik = entity.YorumIcerik,
                    Puan = entity.Puan,
                    OgretmenId = entity.OgretmenId
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpPost]
        [Route("yorumSil")]
        public IActionResult YorumSil([FromBody] OgretmenYorum entity)
        {
            try
            {
                ogretmenYorumServis.Delete(new OgretmenYorum
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
