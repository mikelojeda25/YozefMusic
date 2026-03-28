using YozefMusic.Models;
using YozefMusic.DTOs;

namespace YozefMusic.Repositories.Interfaces;

public interface ISongRepository
{
    Task<IEnumerable<SongDTO>> GetAllSongs();
    //Task<SongDTO> GetSongById(int id);
    Task InsertSong(SongDTO song);
    //Task UpdateSong(Song song);
    //Task<bool> DeleteSong(int id);
}

