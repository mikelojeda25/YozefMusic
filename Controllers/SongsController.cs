using YozefMusic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using YozefMusic.DTOs;


namespace YozefMusic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SongsController : ControllerBase
{
    private readonly ISongService _songService;

    public SongsController(ISongService songService)
    {
        _songService = songService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllSongs()
    {
        var songs = await _songService.GetAllSongs();
        return Ok(songs);
    }

    [HttpPost]
    public async Task<IActionResult> InsertSong(CreateSongDTO song)
    {
        await _songService.InsertSong(song);
        return Ok("Song added successfully!");
    }
}