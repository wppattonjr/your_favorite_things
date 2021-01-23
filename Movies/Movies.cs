using System;
namespace YourFavoriteThings.Movies
{
    public class Movie
    {
            //Properties
            public string Name { get; set; }
            public string Director { get; set; }
            public int Released { get; set; }
            public string Genre { get; set; }

            //Fields - internal private things
            private bool _wonOscar = false;


            //Constructor
            public Movie()
            {

            }

            //Method
            public void Win() {
                if(_wonOscar == false)
                {
                    Console.WriteLine("The movie did not win an Oscar.");
                  
                } else
                {
                    Console.WriteLine("This movie won an Oscar!!");
                                    
                }
            
                }

        }
    }
