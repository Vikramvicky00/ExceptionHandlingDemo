using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public class Customer
    {
        private int custID;
        public int CustId 
        { 
            get
            {
                return custID;
            }
            set
            {
                if(value == 0)
                {
                    throw new ArgumentNullException("Customer id can't be null");
                }
                else
                {
                    custID = value;
                }
            } 
        }

        private int movieID;
        public int MovieID 
        { 
            get
            {
                return movieID;
            } 
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Movie Id can't be null");
                }
                else
                {
                    movieID = value;
                }

            } 
        }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Customer(int custid,int movieid,DateTime borrow)
        {
            CustId = custid;
            MovieID = movieid;
            BorrowDate = borrow;
        }

        public Customer()
        {
        }

        public void BorrowCD(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException("Movie can't be null");
            }
            else
            {  
                ReturnDate = BorrowDate.AddDays(10);
                Console.WriteLine($" {movie.MovieName} Movie CD with {movie.MovieLanguage} language has been issued to CustomerID {CustId} on {BorrowDate} . \n It should be returned by {ReturnDate}");
                Console.WriteLine();
            }

        }
        public bool CheckReturnCD()
        {
            if (DateTime.Now > ReturnDate)
            {
                //Console.WriteLine("Overdue");
                //Console.WriteLine($"The Customer no : {CustId} addded to due list with movie id {MovieID}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
