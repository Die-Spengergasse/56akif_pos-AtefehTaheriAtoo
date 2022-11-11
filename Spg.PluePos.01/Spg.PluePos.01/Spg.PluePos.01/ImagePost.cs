
using System;
namespace Spg.PluePos._01.Model
{
    public class ImagePost : Post
    {
        public ImagePost(string title) : base(title) { }
        public ImagePost(string title, string? url) : base(title)
        {
            this.Url = url;
        }
        public string? Url { get; set; } = string.Empty;
        public override string Html =>
            Url != null
                ? $"<h1>{Title}</h1><img src=\"{Url}\">"
                : throw new ArgumentNullException("Url war NULL");
    }
}