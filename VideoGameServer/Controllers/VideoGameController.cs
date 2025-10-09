using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameServer.Models;

namespace VideoGameServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "Spider-Man 2",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony Interactive Entertainment"
            },
            new VideoGame
            {
                Id = 2,
                Title = "The Legend of Zelda: Tears of the Kingdom",
                Platform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 3,
                Title = "Starfield",
                Platform = "PC",
                Developer = "Bethesda Game Studios",
                Publisher = "Bethesda Softworks"
            },
            new VideoGame
            {
                Id = 4,
                Title = "Cyberpunk 2077",
                Platform = "Xbox Series X",
                Developer = "CD Projekt RED",
                Publisher = "CD Projekt"
            },
            new VideoGame
            {
                Id = 5,
                Title = "God of War Ragnarök",
                Platform = "PS5",
                Developer = "Santa Monica Studio",
                Publisher = "Sony Interactive Entertainment"
            }
        };

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var videoGame = videoGames.FirstOrDefault(game => game.Id == id);
            if (videoGame is null)
                return NotFound();

            return Ok(videoGame);
        }

        [HttpPost]
        public ActionResult<VideoGame> CreateVideoGame(VideoGame newVideoGame)
        {
            if (newVideoGame == null)
                return BadRequest();

            newVideoGame.Id = videoGames.Max(game => game.Id) + 1;
            videoGames.Add(newVideoGame);
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newVideoGame.Id }, newVideoGame);
        }

        [HttpPut("{id}")]
        public ActionResult<VideoGame> UpdateVideoGame(int id, VideoGame updatedVideoGame)
        {
            var videoGame = videoGames.FirstOrDefault(game => game.Id == id);
            if (videoGame is null)
                return NotFound();

            videoGame.Title = updatedVideoGame.Title;
            videoGame.Platform = updatedVideoGame.Platform;
            videoGame.Developer = updatedVideoGame.Developer;
            videoGame.Publisher = updatedVideoGame.Publisher;

            return GetVideoGameById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideoGame(int id)
        {
            var videoGame = videoGames.FirstOrDefault(game => game.Id == id);
            if (videoGame is null)
                return NotFound();

            videoGames.Remove(videoGame);
            return NoContent();
        }
    }
}
