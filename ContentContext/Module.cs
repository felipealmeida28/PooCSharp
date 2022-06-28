using PooCSharp.ContentContext;

namespace PooCSharp
{
    public class Module : Base
    {
        public Module()
        {
            var Lecture = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Module> Lectures { get; set; }

    }
}