using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest_ReturnListClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static List<string> cliente = new List<string> { "Moises Chavez", "Jocelin Martillo", "Leah Chavez" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> GeList_Controller()
        {
            return Ok(cliente);

        }
    }
}
