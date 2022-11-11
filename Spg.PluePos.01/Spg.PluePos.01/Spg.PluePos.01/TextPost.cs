using System;
namespace Spg.PluePos._01.Model
{
    public class TextPost : Post
    {
        public TextPost(string title) : base(title) { }
        public TextPost(string title, string? content) : base(title)
        {
            this.Content = content;
        }
        public string? Content { get; set; } = string.Empty;
        public int Length => Content?.Length ?? 0;
        public override string Html =>
            Content != null
                ? $"<h1>{Title}</h1><p>{Content}</p>"
                : throw new ArgumentNullException("Content war NULL");
    }
}