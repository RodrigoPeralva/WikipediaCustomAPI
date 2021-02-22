using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WikipediaAPI.Controllers {

    [Route("api/v1/[controller]")]
    [ApiController]
    public class WikipediaController : ControllerBase {

        [HttpGet]
        public async Task<IActionResult> GetByWord(string palavra) {
            WikipediaClient wClient = new WikipediaClient();

            var result = await wClient.GetWiki(palavra);

            return Ok(result);
        }
    }
}