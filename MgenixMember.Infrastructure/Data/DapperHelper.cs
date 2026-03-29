using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Infrastructure.Data
{
    using Dapper;
    using System.Data;

    public class DapperHelper
    {
        private readonly IDbConnectionFactory _factory;

        public DapperHelper(IDbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string spName, DynamicParameters param)
        {
            using var connection = _factory.CreateConnection();

            return await connection.QueryAsync<T>(
                spName,
                param,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task<int> ExecuteAsync(string spName, DynamicParameters param)
        {
            using var connection = _factory.CreateConnection();

            return await connection.ExecuteAsync(
                spName,
                param,
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
