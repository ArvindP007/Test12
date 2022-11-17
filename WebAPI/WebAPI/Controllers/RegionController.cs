using Microsoft.AspNetCore.Mvc;
using WebAPI.Models.Domain;
//using WebAPI.Repositories;
using AutoMapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionController : Controller
    {
        private static Walk walk=new Walk();
        [HttpGet]

        public ActionResult<Walk> Get()
        {
            return Ok(walk);
        }

    }
}
