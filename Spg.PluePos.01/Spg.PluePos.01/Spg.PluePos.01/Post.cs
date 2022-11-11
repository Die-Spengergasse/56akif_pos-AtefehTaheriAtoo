using System;
namespace Spg.PluePos._01.Model
{
    public abstract class Post
    {
    
        public Post(string title, DateTime created)
        {
            if (title == null) throw new ArgumentNullException("Titel war NULL!");
            this.Title = title;
            this.Created = created;
        }
        public Post(string title) : this(title, DateTime.Now)
        {
            this.Title = title;
        }
    
        public string Title { get; }
       
        public DateTime Created { get; }

        private int rating;
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value >= 1 && value <= 5
                    ? value
                    : throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");
            }
        }
       
        public abstract string Html { get; }
     
        public SmartPhoneApp? SmartPhone { get; set; } = null;
       
        public override string ToString()
        {
            return Html;
        }
    }
}