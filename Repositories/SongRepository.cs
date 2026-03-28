using YozefMusic.Repositories.Interfaces;
using YozefMusic.Models;
using YozefMusic.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;


namespace YozefMusic.Repositories;

public class SongRepository : ISongRepository
{
  private readonly string _connectionString;

  public SongRepository(IConfiguration configuration)
  {
    _connectionString = configuration.GetConnectionString("DefaultConnection")!;
  }

  public async Task<IEnumerable<SongDTO>> GetAllSongs()
  {
    using var connection = new SqlConnection (_connectionString);
    return await connection.QueryAsync<SongDTO>("sp_GetAllSongs", 
      commandType: CommandType.StoredProcedure);
  }
}