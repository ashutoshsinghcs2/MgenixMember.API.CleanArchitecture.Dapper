using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Infrastructure.Data
{
    using System.Data;
    using System.Xml.Linq;
    using Dapper;

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

        //  Get Single Record
        public async Task<T> GetAsync<T>(string spName, DynamicParameters param)
        {
            using var connection = _factory.CreateConnection();

            return await connection.QueryFirstOrDefaultAsync<T>(
                spName,
                param,
                commandType: CommandType.StoredProcedure
            );
        }

        //  Get List
        public async Task<IEnumerable<T>> GetAllAsync<T>(string spName, DynamicParameters param)
        {
            using var connection = _factory.CreateConnection();

            return await connection.QueryAsync<T>(
                spName,
                param,
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
