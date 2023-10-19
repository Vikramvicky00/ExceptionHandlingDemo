using System;


namespace MovieLib
{
    public class Movie
    {
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
                    throw new ArgumentNullException("Movie ID cant be null");
                }
                else
                {
                    movieID = value;
                }

            }
        }
        private String movieName;
        public string MovieName
        {
            get
            {
                return movieName;
            }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Movie Name Can't Be Empty");
                }
                else
                {
                    movieName = value;
                }
            }
        }

        private String movielanguage;
        public string MovieLanguage 
        {
            get 
            {
                return movielanguage;
            } 
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Movie Language Can't Be Empty");
                }
                else
                {
                    movielanguage = value;
                }
            }
        }
    }
}
