namespace YozefMusic.Models;

public class Song
{
    public int SongId { get; set; }
    public string SongTitle { get; set; }
    public string SongDescription { get; set; }
    public int AlbumID { get; set; }
    public string Genre { get; set; }
    public bool IsActive { get; set; }
    public DateTime DateCreated { get; set; }
}