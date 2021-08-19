
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StreamZ.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StreamController : ControllerBase
    {

        [HttpGet]
        public async Task<FileStreamResult> Get()
        {
            var name = @"/Users/italosantana/Downloads/Rio De Janeiro Travel Film 4K _720P HD.mp4";

            var stream = await GetVideoByName(name);

            return new FileStreamResult(stream, "video/mp4");
        }


        public async Task<Stream> GetVideoByName(string name)
        {
            return await Task.FromResult(new StreamReader(name).BaseStream);
        }
    }
}
