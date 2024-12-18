using System.Text.Json;
namespace NC_MVC
{
    public class AuthorModel
    {
        private List<Author> Authors = new List<Author>();
        public AuthorModel()
        {
            Authors.AddRange(ReadAuthors());
        }
        public List<Author> ReadAuthors()
        {
            return JsonSerializer.Deserialize<List<Author>>( File.ReadAllText("Authors.json"));
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
        public List<Author> ShowAuthors()
        {
            return Authors;
        }
    }
}
