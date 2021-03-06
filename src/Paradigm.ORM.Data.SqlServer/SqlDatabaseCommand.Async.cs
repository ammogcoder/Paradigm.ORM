using System;
using System.Threading.Tasks;
using Paradigm.ORM.Data.Database;
using Paradigm.ORM.Data.Exceptions;

namespace Paradigm.ORM.Data.SqlServer
{
    internal partial class SqlDatabaseCommand
    {
        #region Public Methods

        /// <summary>
        /// Sends the CommandText to the <see cref="SqlDatabaseConnector" />
        /// and builds a <see cref="SqlDatabaseReader" />.
        /// </summary>
        /// <returns>
        /// A database reader object.
        /// </returns>
        public async Task<IDatabaseReader> ExecuteReaderAsync()
        {
            try
            {
                this.Command.Transaction = this.Connector.ActiveTransaction?.Transaction;
                return new SqlDatabaseReader(await this.Command.ExecuteReaderAsync());
            }
            catch (Exception e)
            {
                throw new DatabaseCommandException(this, e);
            }
        }

        /// <summary>
        /// Executes a SQL statement against the connection and returns the number
        /// of rows affected.
        /// </summary>
        /// <returns>
        /// The number of rows affected.
        /// </returns>
        public async Task<int> ExecuteNonQueryAsync()
        {
            try
            {
                this.Command.Transaction = this.Connector.ActiveTransaction?.Transaction;
                return await this.Command.ExecuteNonQueryAsync();
            }
            catch (Exception e)
            {
                throw new DatabaseCommandException(this, e);
            }
        }

        /// <summary>
        /// Executes the query, and returns the first column of the first row in the result
        /// set returned by the query. Additional columns or rows are ignored.
        /// </summary>
        /// <returns>
        /// The first column of the first row in the result set, or a null reference
        /// if the result set is empty.
        /// </returns>
        public async Task<object> ExecuteScalarAsync()
        {
            try
            {
                this.Command.Transaction = this.Connector.ActiveTransaction?.Transaction;
                return await this.Command.ExecuteScalarAsync();
            }
            catch (Exception e)
            {
                throw new DatabaseCommandException(this, e);
            }
        }

        #endregion
    }
}