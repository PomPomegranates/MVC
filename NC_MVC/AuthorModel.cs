using System.Text.Json;
namespace NC_MVC
{
    public class AuthorModel
    {
        public List<Author> ReadAuthors()
        {
            return JsonSerializer.Deserialize<List<Author>>( File.ReadAllText("Authors.json"));
        }
    }
}
