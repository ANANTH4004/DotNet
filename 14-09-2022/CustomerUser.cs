using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDemo
{
    [Serializable()]
    public class CustomerUser
    {
        public long UserId { get; set; }
        public string Password { get; set; }
        public bool LoginStatus { get; set; }
       public List<Movie> SearchedMovieList = new List<Movie>();
       public List<Movie> WatchedMovieList = new List<Movie>();
        //private List<Movie> _MoviesList;

        //public List<Movie> SearchedMovieList
        //{
        //    get { return _MoviesList; }
        //    set { _MoviesList = value; }
        //}

        public void ValidateUser()
        {
            if (this.Password == this.UserId+"password")
            {
                this.LoginStatus = true;
            }
            else
            {
                this.LoginStatus = false;
            }
        }
        public void BorrowMovie(Movie m)
        {
            this.SearchedMovieList.Add(m);
        }
        public void SearchByLanguage(string language)
        {
            foreach (var item in Movie.MoviesList)
            {
                if (item.Language == language)
                {
                    this.SearchedMovieList.Add(item);
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void SearchByGenre(string genre)
        {
            foreach (var item in Movie.MoviesList)
            {
                if (item.genres == genre)
                {
                    this.SearchedMovieList.Add(item);
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void WatchedMovie(Movie m )
        {
            this.WatchedMovieList.Add(m);
        }
    }
}
