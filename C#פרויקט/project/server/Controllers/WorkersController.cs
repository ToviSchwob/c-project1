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
    public class WorkersController : ControllerBase
    {
        IWorker worker;
        public WorkersController(BLManager blw)
        {
            this.worker = blw.Worker;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            if (worker.GetAll() != null)
            {
                return Ok(worker.GetAll());
            }
            return BadRequest();
        }
    }
}
