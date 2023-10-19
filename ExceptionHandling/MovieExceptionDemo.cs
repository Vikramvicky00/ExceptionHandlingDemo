using System;
using System.Collections.Generic;
using MovieLib;

namespace ExceptionHandling
{
    public class MovieExceptionDemo
    {
        static void Main(string[] args)
        {
			try
			{
                //List<Movie> MovieList = new List<Movie>();
                List<Customer> DueList = new List<Customer>();
                List<Customer> customerList = new List<Customer>();

                Movie movie = new Movie();
                movie.MovieID = 52;
                movie.MovieName = "SpiderMan";
                movie.MovieLanguage = "English";
                //MovieList.Add(movie);

                Movie movie2 = new Movie();
                movie2.MovieID = 205;
                movie2.MovieName = "IronMan";
                movie2.MovieLanguage = "English";
                //MovieList.Add(movie2);

                Movie movie3 = new Movie();
                movie3.MovieID = 525;
                movie3.MovieName = "Captain America";
                movie3.MovieLanguage = "English";
                //MovieList.Add(movie3);


                Customer c1 = new Customer(101, 52, DateTime.Parse("12-08-2023"));
                customerList.Add(c1);
                Customer c2 = new Customer(102, 205, DateTime.Parse("15-11-2023"));
                customerList.Add(c2);
                Customer c3 = new Customer(103, 005, DateTime.Now);
                customerList.Add(c3);

                c1.BorrowCD(movie);
                c2.BorrowCD(movie2);
                c3.BorrowCD(movie3);

                foreach (var c in customerList)
                {
                    if (c.CheckReturnCD())
                    {
                        DueList.Add(c);
                    }
                }

                foreach (var cust in DueList)
                {
                    Console.WriteLine("The Due List :");
                    Console.WriteLine($"Customer with ID {cust.CustId} is pending to return the MovieCD with MovieID:  {cust.MovieID}");
                    Console.WriteLine();
                }
               
			}
			catch (Exception msg)
			{
                Console.WriteLine(msg.Message);
            }

            Console.ReadLine();
        }
    }
}
