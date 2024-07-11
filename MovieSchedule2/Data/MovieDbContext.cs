using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieSchedule2.Model;

namespace MovieSchedule2.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=movie_schedule";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //MovieActor
            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.movieID, ma.actorID });

            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(ma => ma.movieID);

            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(ma => ma.actorID);

            //MovieCountry
            modelBuilder.Entity<MovieCountry>()
               .HasKey(mc => new { mc.movieID, mc.countryID });

            modelBuilder.Entity<MovieCountry>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieCountries)
                .HasForeignKey(mc => mc.movieID);

            modelBuilder.Entity<MovieCountry>()
                .HasOne(mc => mc.Country)
                .WithMany(c => c.MovieCountries)
                .HasForeignKey(mc => mc.countryID);

            //MovieDirector
            modelBuilder.Entity<MovieDirector>()
               .HasKey(mc => new { mc.movieID, mc.directorID });

            modelBuilder.Entity<MovieDirector>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieDirectors)
                .HasForeignKey(mc => mc.movieID);

            modelBuilder.Entity<MovieDirector>()
                .HasOne(mc => mc.Director)
                .WithMany(c => c.MovieDirectors)
                .HasForeignKey(mc => mc.directorID);

            //MovieGenre
            modelBuilder.Entity<MovieGenre>()
               .HasKey(mc => new { mc.movieID, mc.genreID });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mc => mc.movieID);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mc => mc.Genre)
                .WithMany(c => c.MovieGenres)
                .HasForeignKey(mc => mc.genreID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
