namespace PooCSharp.ContentContext
{
    public abstract class Content : Base
    {
        public Content(String title, String url)
        {

            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}