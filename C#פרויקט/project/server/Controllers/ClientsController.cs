using Bl;
using Bl.BlApi;
using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        IClient client;
        public ClientsController(BLManager bL)
        {
            this.client = bL.Client;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            if (client.GetAll() != null)
            {
                return Ok(client.GetAll());
            }
            return BadRequest();

        }

    }
}

  
