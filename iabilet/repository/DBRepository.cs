using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using iabilet.domain;
using iabilet.domain.validators;

namespace iabilet.repository
{
    public class DBRepository
    {
        private readonly string _connectionString =
            @"Server=DESKTOP-D3O620O;Database=iabilet;Integrated Security=true;TrustServerCertificate=true;";

        private ArtistValidator _validator = new ArtistValidator();

        public List<Genre> GetAllGenres()
        {
            List<Genre> genres = new List<Genre>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection state: {0}", connection.State);

                    SqlCommand command = new SqlCommand("select * from Genuri", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            int popularity = reader.GetInt32(1);
                            int id = reader.GetInt32(2);

                            genres.Add(new Genre
                            {
                                Id = id,
                                Name = name,
                                Popularity = popularity
                            });
                        }
                    }
                    
                    connection.Close();

                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            return genres;
        }
        
        public List<Artist> GetAllArtistsByGenre(int genreId)
        {
            List<Artist> artists = new List<Artist>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection state: {0}", connection.State);

                    SqlCommand command = new SqlCommand("select * from Artisti " +
                                                        "where ID_GEN = @genreId", connection);
                    command.Parameters.AddWithValue("@genreId", genreId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            bool band = reader.GetBoolean(1);
                            int id = reader.GetInt32(3);

                            artists.Add(new Artist()
                            {
                                Id = id,
                                Name = name,
                                Band = band,
                                GenreId = genreId
                            });
                        }
                    }
                    
                    connection.Close();

                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            return artists;
        }

        public Artist DeleteArtist(Artist artist)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection state: {0}", connection.State);

                    SqlCommand command = new SqlCommand("delete from Artisti where ID=@artistId", connection);
                    command.Parameters.AddWithValue("@artistId", artist.Id);
                    int deletedRowsCount = command.ExecuteNonQuery();
                    connection.Close();
                    
                    if (deletedRowsCount > 0)
                    {
                        return artist;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            return null;
        }
        
        public Artist UpdateArtist(Artist artist)
        {
            try
            {
                _validator.Validate(artist);
                
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection state: {0}", connection.State);

                    SqlCommand command = new SqlCommand("update Artisti set NUME=@artistName, FORMATIE=@band " +
                                                        "where ID=@artistId", connection);
                    command.Parameters.AddWithValue("@artistId", artist.Id);
                    command.Parameters.AddWithValue("@band", artist.Band);
                    command.Parameters.AddWithValue("@artistName", artist.Name);
                    int updatedRowsCount = command.ExecuteNonQuery();
                    connection.Close();
                    
                    if (updatedRowsCount > 0)
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            return artist;
        }
        
        public Artist AddArtist(Artist artist)
        {
            try
            {
                _validator.Validate(artist);
                
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection state: {0}", connection.State);

                    SqlCommand command = new SqlCommand("insert into Artisti(nume, formatie, id_gen) " +
                                                        "values (@artistName, @band, @genreId)", connection);
                    command.Parameters.AddWithValue("@band", artist.Band);
                    command.Parameters.AddWithValue("@artistName", artist.Name);
                    command.Parameters.AddWithValue("@genreId", artist.GenreId);
                    int addedRowsCount = command.ExecuteNonQuery();
                    connection.Close();
                    
                    if (addedRowsCount > 0)
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            return artist;
        }
    }
}