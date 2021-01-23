using System;

using YourFavoriteThings.Movies;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie();
            {
                movie1.Name = "Do the Right Thing";
                movie1.Director = "Spike Lee";
                movie1.Genre = "Comedy | Drama";
                movie1.Released = 1989;
                movie1.Win();
                Console.WriteLine($"{movie1.Name} was released in {movie1.Released}. It was directed by {movie1.Director} and is considered to be a {movie1.Genre}.");
            }

            var movie2 = new Movie();
            {
                movie2.Name = "The Matrix";
                movie2.Director = "The Wachowski Brothers";
                movie2.Genre = "Action | Sci-Fi";
                movie2.Released = 1999;
                movie2.Win();
                Console.WriteLine($"{movie2.Name} was released in {movie2.Released}. It was directed by {movie2.Director} and is considered to be a {movie2.Genre}.");
            }
        }
    }
}
