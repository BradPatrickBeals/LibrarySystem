using Microsoft.Extensions.Options;
using MySqlConnector;
using System.Data;
namespace LibrarySystem.Data
{
    public sealed class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly IOptions<DbOptions> _databaseSettings;

        private readonly string _connectionString;

        public MySqlConnectionFactory(IOptions<DbOptions> databaseSettings)
        {
            _databaseSettings = databaseSettings;
            _connectionString = _databaseSettings.Value.DefaultConnection;
        }

        public IDbConnection Create()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
