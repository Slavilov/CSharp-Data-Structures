using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Working_with_Complex_Data_Types
{
    internal class Book
    {
		private double rating;
		private string author;
		private string tittle;

        public Book(string tittle, string author, double rating)
        {
            this.Tittle = tittle;
			this.Author = author;
			this.Rating = rating;
        }

        public double Rating
		{
			get { return rating; }
			private set { rating = value; }
		}

		public string Author
		{
			get { return author; }
            private set { author = value; }
		}

		public string Tittle
		{
			get { return tittle; }
            private set { tittle = value; }
		}

	}
}
