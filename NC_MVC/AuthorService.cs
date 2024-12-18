namespace NC_MVC
{
    public class AuthorService
    {
        private readonly AuthorModel _authorModel;
        public AuthorService(AuthorModel authorModel)
        {
            _authorModel = authorModel;
        }

        public List<Author> GetAuthors() 
        {
            return _authorModel.ReadAuthors();
        }

        public Author? GetAuthor(int id)

        {
            Author? foundAuthor = _authorModel.ReadAuthors().Find(x => x.Id == id);
            return foundAuthor;
        }
    }
}
