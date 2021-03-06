using Paradigm.ORM.Data.CommandBuilders;
using Paradigm.ORM.Data.Database;
using Paradigm.ORM.Data.Descriptors;

namespace Paradigm.ORM.Data.Cassandra.CommandBuilders
{
    /// <summary>
    /// Provides an implementation for mysql select command builder objects.
    /// </summary>
    /// <seealso cref="SelectCommandBuilderBase" />
    /// <seealso cref="ISelectCommandBuilder" />
    public class CqlSelectCommandBuilder : SelectCommandBuilderBase
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CqlSelectCommandBuilder"/> class.
        /// </summary>
        /// <param name="connector">A database connector.</param>
        /// <param name="descriptor">A table type descriptor.</param>
        public CqlSelectCommandBuilder(IDatabaseConnector connector, ITableDescriptor descriptor) : base(connector, descriptor)
        {
        }

        #endregion
    }
}