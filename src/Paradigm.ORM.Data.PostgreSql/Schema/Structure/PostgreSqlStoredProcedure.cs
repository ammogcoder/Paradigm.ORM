﻿using Paradigm.ORM.Data.Attributes;
using Paradigm.ORM.Data.Database.Schema.Structure;

namespace Paradigm.ORM.Data.PostgreSql.Schema.Structure
{
    /// <summary>
    /// Provides a database stored procedure schema.
    /// </summary>
    /// <seealso cref="IStoredProcedure" />
    [Table("routines", Catalog = "information_schema")]
    public class PostgreSqlStoredProcedure : IStoredProcedure
    {
        /// <summary>
        /// Gets the name of the stored procedure.
        /// </summary>
        [Column("routine_name", "text")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the name of the catalog where the routine resides.
        /// </summary>
        [Column("routine_catalog", "text")]
        public string CatalogName { get; set; }

        /// <summary>
        /// Gets the name of the schema where the view resides.
        /// </summary>
        [Column("routine_schema", "text")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"Stored Procedure {this.SchemaName}.{this.Name}";
    }
}