using YozefMusic.DTOs;

namespace YozefMusic.Services.Interfaces;

public interface ISongService
{
    Task<IEnumerable<SongDTO>> GetAllSongs();
    
}