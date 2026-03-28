// CreateSongDTO.cs
namespace YozefMusic.DTOs;

public class CreateSongDTO
{
    public string SongTitle { get; set; }
    public string SongDescription { get; set; }
    public int AlbumID { get; set; }
    public string Genre { get; set; }
}