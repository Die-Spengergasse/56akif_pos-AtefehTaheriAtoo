
using System;
using System.Collections.Generic;
namespace Spg.PluePos._01.Model
{
    public class SmartPhoneApp : List<Post>
    {
        public SmartPhoneApp(string smartPhoneId)
        {
            this.SmartPhoneId = smartPhoneId;
        }
       
        public string SmartPhoneId { get; set; }

        public new void Add(Post post)
        {
            if (post == null) throw new ArgumentNullException("Post war NULL!");
            post.SmartPhone = this;
            base.Add(post);
        }
        
        public string ProcessPosts()
        {
            string html = "";
            foreach (Post post in this)
            {
                html += $"{post.Html}\n";
            }
            return html;
        }

       
        public int CalcRating()
        {
            int summe = 0;
            foreach (Post post in this)
            {
                summe += post.Rating;
            }
            return summe;
        }

       
        public Post? this[string title]
        {
            get
            {
                foreach (Post post in this)
                {
                    if (post.Title == title)
                    {
                        return post;
                    }
                }
                return null;
            }
        }
    }
}
