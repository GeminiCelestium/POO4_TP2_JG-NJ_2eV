using Microsoft.AspNetCore.Mvc;
using ModernRecrut.Favoris.API.Models;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModernRecrut.Favoris.API.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class FavoriController : ControllerBase
    {
        // GET: api/<FavoriController>
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IHttpActionResult ObtenirTous()
        {
            //var ipAddress = Request.GetClientIpAddress();
            //var favoris = _favorisManager.GetFavoris(ipAddress);
            //return Ok(favoris);

            return null;
        }

        // GET api/<FavoriController>/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FavoriController>
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IHttpActionResult AjouterFavoris(string favoris)
        {
            //var ipAddress = Request.GetClientIpAddress();
            //_favorisManager.AddFavoris(ipAddress, favoris);
            //return Ok();

            return null;
        }

        // DELETE api/<FavoriController>/5
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public IHttpActionResult SupprimerFavoris()
        {
            //var ipAddress = Request.GetClientIpAddress();
            //_favorisManager.RemoveFavoris(ipAddress);
            //return Ok();

            return null;
        }
    }
}
