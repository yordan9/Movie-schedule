using Microsoft.EntityFrameworkCore;
using MovieSchedule2.Data;
using MovieSchedule2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSchedule2.Service
{
    public class MovieInformation
    {
        //for AddMovie
        public void AddMovieToDB(TextBox name_txtB, TextBox actor_txtB, TextBox director_txtB, TextBox genre_txtB, 
             TextBox releaseDate_txtB, TextBox country_txtB, Label success, Label fail)
        {
            using (var db = new MovieDbContext())
            {
                try
                {
                    string movieName = name_txtB.Text;
                    string actorNames = actor_txtB.Text;
                    string directorNames = director_txtB.Text;
                    string genreNames = genre_txtB.Text;
                    DateOnly releaseDate;
                    string countryNames = country_txtB.Text;

                    if (!DateOnly.TryParse(releaseDate_txtB.Text, out releaseDate))
                    {
                        MessageBox.Show("Invalid date format. Please enter a valid date.");
                        return;
                    }

                    var movie = new Movie
                    {
                        Name = movieName,
                        releaseDate = releaseDate
                    };

                    if (movie.MovieActors == null)
                    {
                        movie.MovieActors = new List<MovieActor>();
                    }

                    if (movie.MovieCountries == null)
                    {
                        movie.MovieCountries = new List<MovieCountry>();
                    }

                    if (movie.MovieDirectors == null)
                    {
                        movie.MovieDirectors = new List<MovieDirector>();
                    }

                    if (movie.MovieGenres == null)
                    {
                        movie.MovieGenres = new List<MovieGenre>();
                    }

                    var actors = actorNames.Split(',').Select(x => x.Trim()).ToList();
                    foreach (var actorName in actors)
                    {
                        var nameParts = actorName.Split(' ');
                        if (nameParts.Length == 2)
                        {
                            var actor = new Actor
                            {
                                Name = nameParts[0],
                                Family = nameParts[1]
                            };

                            movie.MovieActors.Add(new MovieActor { Actor = actor });
                        }
                    }

                    var directors = directorNames.Split(',').Select(d => d.Trim()).ToList();
                    foreach (var directorName in directors)
                    {
                        var nameParts = directorName.Split(' ');
                        if (nameParts.Length == 2)
                        {
                            var director = new Director
                            {
                                Name = nameParts[0],
                                Family = nameParts[1]

                            };

                            movie.MovieDirectors.Add(new MovieDirector { Director = director });
                        }
                    }

                    var genres = genreNames.Split(',').Select(g => g.Trim()).ToList();
                    foreach (var genreName in genres)
                    {
                        var genre = new Genre { Name = genreName };
                        movie.MovieGenres.Add(new MovieGenre { Genre = genre });
                    }

                    var countries = countryNames.Split(',').Select(x => x.Trim()).ToList();
                    foreach (var countryName in countries)
                    {
                        var country = new Country { Name = countryName };
                        movie.MovieCountries.Add(new MovieCountry { Country = country });
                    }

                    db.Movies.Add(movie);
                    db.SaveChanges();

                    success.Visible = true;
                    fail.Visible = false;
                }
                catch (Exception)
                {
                    fail.Visible = true;
                    success.Visible = false;
                    throw;
                }
            }
        }

        //for Form1
        public void InitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("identify number", "");
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("MovieName", "Movie Name");
            dataGridView.Columns.Add("MainActors", "Main Character/s");
            dataGridView.Columns.Add("Director", "Director");
            dataGridView.Columns.Add("ReleaseDate", "Release Date");
            dataGridView.Columns.Add("Genre", "Genre/s");
            dataGridView.Columns.Add("Countries", "Country");
              
            dataGridView.Columns["identify number"].Width = 0;
            dataGridView.Columns["ID"].Width = 70;
            dataGridView.Columns["MovieName"].Width = 350;
            dataGridView.Columns["MainActors"].Width = 350;
            dataGridView.Columns["Director"].Width = 300;
            dataGridView.Columns["ReleaseDate"].Width = 230;
            dataGridView.Columns["Genre"].Width = 270;
            dataGridView.Columns["Countries"].Width = 250;
        }

        public void LoadMovies(DataGridView dataGridView )
        {
            using (var db = new MovieDbContext())
            {
                try
                {
                    dataGridView.Rows.Clear();

                    var movies = db.Movies
                        .Include(m => m.MovieActors)
                            .ThenInclude(ma => ma.Actor)
                        .Include(m => m.MovieCountries)
                            .ThenInclude(mc => mc.Country)
                        .Include(m => m.MovieDirectors)
                            .ThenInclude(m => m.Director)
                        .Include(m => m.MovieGenres)
                            .ThenInclude(m => m.Genre)
                        .ToList();

                    if (!movies.Any())
                    {
                        MessageBox.Show("No movies found.");
                        return;
                    }

                    int idCounter = 1;
                    foreach (var movie in movies)
                    {
                        var actorNames = string.Join(", ", movie.MovieActors.Select(ma => $"{ma.Actor.Name} {ma.Actor.Family}"));
                        var countryNames = string.Join(", ", movie.MovieCountries.Select(mc => $"{mc.Country.Name}"));
                        var directorNames = string.Join(", ", movie.MovieDirectors.Select(md => $"{md.Director.Name} {md.Director.Family}"));
                        var genreNames = string.Join(", ", movie.MovieGenres.Select(mg => $"{mg.Genre.Name}"));

                        dataGridView.Rows.Add(movie.ID, idCounter++, movie.Name, actorNames, directorNames, movie.releaseDate, genreNames, countryNames);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void DeleteMovie(DataGridView dataGridView, Label delete, Label success,Label fail)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int movieID = Convert.ToInt32(dataGridView.Rows[selectedRowIndex].Cells["identify number"].Value);

                using (var db = new MovieDbContext())
                {
                    try
                    {
                        var movie = db.Movies
                            .Include(m => m.MovieActors)
                            .Include(m => m.MovieCountries)
                            .Include(m => m.MovieDirectors)
                            .Include(m => m.MovieGenres)
                            .FirstOrDefault(m => m.ID == movieID);

                        if (movie != null)
                        {
                            db.Movies.Remove(movie);
                            db.SaveChanges();
                            LoadMovies(dataGridView);

                            delete.Visible = true;
                            success.Visible = false;
                            fail.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Movie not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select movie to delete!");
            }
        }

        public void UpdateMovie(DataGridView dataGridView, Label success)
        {
            using (var db = new MovieDbContext())
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int movieId = Convert.ToInt32(row.Cells["identify number"].Value);
                        var movie = db.Movies
                            .Include(m => m.MovieActors)
                            .Include(m => m.MovieCountries)
                            .Include(m => m.MovieDirectors)
                            .Include(m => m.MovieGenres)
                            .FirstOrDefault(m => m.ID == movieId);

                        if (movie != null)
                        {
                            movie.Name = row.Cells["MovieName"].Value.ToString();
                            movie.releaseDate = DateOnly.Parse(row.Cells["ReleaseDate"].Value.ToString());

                            var newActors = row.Cells["MainActors"].Value.ToString().Split(',').Select(a => a.Trim()).ToList();
                            movie.MovieActors.Clear();
                            foreach (var actorName in newActors)
                            {
                                var nameParts = actorName.Split(' ');
                                if (nameParts.Length == 2)
                                {
                                    var actor = new Actor
                                    {
                                        Name = nameParts[0],
                                        Family = nameParts[1]
                                    };
                                    movie.MovieActors.Add(new MovieActor { Actor = actor });
                                }
                            }

                            var newDirectors = row.Cells["Director"].Value.ToString().Split(',').Select(d => d.Trim()).ToList();
                            movie.MovieDirectors.Clear();
                            foreach (var directorName in newDirectors)
                            {
                                var nameParts = directorName.Split(' ');
                                if (nameParts.Length == 2)
                                {
                                    var director = new Director
                                    {
                                        Name = nameParts[0],
                                        Family = nameParts[1]
                                    };
                                    movie.MovieDirectors.Add(new MovieDirector { Director = director });
                                }
                            }

                            var newGenres = row.Cells["Genre"].Value.ToString().Split(',').Select(g => g.Trim()).ToList();
                            movie.MovieGenres.Clear();
                            foreach (var genreName in newGenres)
                            {
                                var genre = new Genre { Name = genreName };
                                movie.MovieGenres.Add(new MovieGenre { Genre = genre });
                            }

                            var newCountries = row.Cells["Countries"].Value.ToString().Split(',').Select(c => c.Trim()).ToList();
                            movie.MovieCountries.Clear();
                            foreach (var countryName in newCountries)
                            {
                                var country = new Country { Name = countryName };
                                movie.MovieCountries.Add(new MovieCountry { Country = country });
                            }
                        }
                    }

                    db.SaveChanges();
                    success.Visible = true;
                    LoadMovies(dataGridView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        //for search txtB
        public void SearchMovies(DataGridView dataGridView, string searchText)
        {
            using (var db = new MovieDbContext())
            {
                try
                {
                    dataGridView.Rows.Clear();

                    var movies = db.Movies
                        .Include(m => m.MovieActors)
                            .ThenInclude(ma => ma.Actor)
                        .Include(m => m.MovieCountries)
                            .ThenInclude(mc => mc.Country)
                        .Include(m => m.MovieDirectors)
                            .ThenInclude(md => md.Director)
                        .Include(m => m.MovieGenres)
                            .ThenInclude(mg => mg.Genre)
                        .Where(m => m.Name.Contains(searchText))
                        .ToList();

                    int idCounter = 1;
                    foreach (var movie in movies)
                    {
                        var actorNames = string.Join(", ", movie.MovieActors.Select(ma => $"{ma.Actor.Name} {ma.Actor.Family}"));
                        var countryNames = string.Join(", ", movie.MovieCountries.Select(mc => $"{mc.Country.Name}"));
                        var directorNames = string.Join(", ", movie.MovieDirectors.Select(md => $"{md.Director.Name} {md.Director.Family}"));
                        var genreNames = string.Join(", ", movie.MovieGenres.Select(mg => $"{mg.Genre.Name}"));

                        dataGridView.Rows.Add(movie.ID, idCounter++, movie.Name, actorNames, directorNames, movie.releaseDate, genreNames, countryNames);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
