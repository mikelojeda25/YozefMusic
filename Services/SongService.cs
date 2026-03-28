using YozefMusic.DTOs;
using YozefMusic.Services.Interfaces;
using YozefMusic.Repositories.Interfaces;

namespace YozefMusic.Services;

public class SongService : ISongService
{
  private readonly ISongRepository _songRepository;

  public SongService(ISongRepository songRepository)
  {
    _songRepository = songRepository;
  }

  public async Task<IEnumerable<SongDTO>> GetAllSongs()
  {
    return await _songRepository.GetAllSongs();
  }
}