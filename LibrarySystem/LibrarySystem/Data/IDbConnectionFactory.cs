using System.Data;

namespace LibrarySystem.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}
