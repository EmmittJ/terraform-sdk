using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_all in GoogleDatastreamStream.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backfill_all";

    /// <summary>
    /// MongodbExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlock>? MongodbExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlock>>("mongodb_excluded_objects");
        set => SetArgument("mongodb_excluded_objects", value);
    }

    /// <summary>
    /// MysqlExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlock>? MysqlExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlock>>("mysql_excluded_objects");
        set => SetArgument("mysql_excluded_objects", value);
    }

    /// <summary>
    /// OracleExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlock>? OracleExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlock>>("oracle_excluded_objects");
        set => SetArgument("oracle_excluded_objects", value);
    }

    /// <summary>
    /// PostgresqlExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlock>? PostgresqlExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlock>>("postgresql_excluded_objects");
        set => SetArgument("postgresql_excluded_objects", value);
    }

    /// <summary>
    /// SalesforceExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SalesforceExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlock>? SalesforceExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlock>>("salesforce_excluded_objects");
        set => SetArgument("salesforce_excluded_objects", value);
    }

    /// <summary>
    /// SqlServerExcludedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerExcludedObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlock>? SqlServerExcludedObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlock>>("sql_server_excluded_objects");
        set => SetArgument("sql_server_excluded_objects", value);
    }

}

/// <summary>
/// Block type for mongodb_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mongodb_excluded_objects";

    /// <summary>
    /// Databases block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Databases is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Databases block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlock> Databases
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlock>>("databases");
        set => SetArgument("databases", value);
    }

}

/// <summary>
/// Block type for databases in GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "databases";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Collections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlock>? Collections
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlock>>("collections");
        set => SetArgument("collections", value);
    }

}

/// <summary>
/// Block type for collections in GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collections";

    /// <summary>
    /// Collection name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformValue<string> Collection
    {
        get => GetArgument<TerraformValue<string>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMongodbExcludedObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

}

/// <summary>
/// Block type for mysql_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_excluded_objects";

    /// <summary>
    /// MysqlDatabases block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MysqlDatabases is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MysqlDatabases block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlock> MysqlDatabases
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlock>>("mysql_databases");
        set => SetArgument("mysql_databases", value);
    }

}

/// <summary>
/// Block type for mysql_databases in GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_databases";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// MysqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>? MysqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>>("mysql_tables");
        set => SetArgument("mysql_tables", value);
    }

}

/// <summary>
/// Block type for mysql_tables in GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// MysqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>? MysqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>>("mysql_columns");
        set => SetArgument("mysql_columns", value);
    }

}

/// <summary>
/// Block type for mysql_columns in GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockMysqlExcludedObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_columns";

    /// <summary>
    /// Column collation.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => GetArgument<TerraformValue<string>>("collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for oracle_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_excluded_objects";

    /// <summary>
    /// OracleSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OracleSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OracleSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlock> OracleSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlock>>("oracle_schemas");
        set => SetArgument("oracle_schemas", value);
    }

}

/// <summary>
/// Block type for oracle_schemas in GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// OracleTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlock>? OracleTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlock>>("oracle_tables");
        set => SetArgument("oracle_tables", value);
    }

}

/// <summary>
/// Block type for oracle_tables in GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// OracleColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>? OracleColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>>("oracle_columns");
        set => SetArgument("oracle_columns", value);
    }

}

/// <summary>
/// Block type for oracle_columns in GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockOracleExcludedObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column encoding.
    /// </summary>
    public TerraformValue<string> Encoding
        => AsReference("encoding");

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for postgresql_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_excluded_objects";

    /// <summary>
    /// PostgresqlSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostgresqlSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostgresqlSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlock> PostgresqlSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlock>>("postgresql_schemas");
        set => SetArgument("postgresql_schemas", value);
    }

}

/// <summary>
/// Block type for postgresql_schemas in GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_schemas";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// PostgresqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>? PostgresqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>>("postgresql_tables");
        set => SetArgument("postgresql_tables", value);
    }

}

/// <summary>
/// Block type for postgresql_tables in GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// PostgresqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>? PostgresqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>>("postgresql_columns");
        set => SetArgument("postgresql_columns", value);
    }

}

/// <summary>
/// Block type for postgresql_columns in GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockPostgresqlExcludedObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for salesforce_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce_excluded_objects";

    /// <summary>
    /// Objects block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Objects is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Objects block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlock> Objects
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlock>>("objects");
        set => SetArgument("objects", value);
    }

}

/// <summary>
/// Block type for objects in GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "objects";

    /// <summary>
    /// Name of object in Salesforce Org.
    /// </summary>
    public TerraformValue<string>? ObjectName
    {
        get => GetArgument<TerraformValue<string>>("object_name");
        set => SetArgument("object_name", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSalesforceExcludedObjectsBlockObjectsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for sql_server_excluded_objects in GoogleDatastreamStreamBackfillAllBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_server_excluded_objects";

    /// <summary>
    /// Schemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlock> Schemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlock>>("schemas");
        set => SetArgument("schemas", value);
    }

}

/// <summary>
/// Block type for schemas in GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Tables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlock>? Tables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlock>>("tables");
        set => SetArgument("tables", value);
    }

}

/// <summary>
/// Block type for tables in GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// Columns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

}

/// <summary>
/// Block type for columns in GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlockSqlServerExcludedObjectsBlockSchemasBlockTablesBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The SQL Server data type. Full data types list can be found here:
    /// https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}


/// <summary>
/// Block type for backfill_none in GoogleDatastreamStream.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillNoneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backfill_none";

}


/// <summary>
/// Block type for destination_config in GoogleDatastreamStream.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_config";

    /// <summary>
    /// Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConnectionProfile is required")]
    public required TerraformValue<string> DestinationConnectionProfile
    {
        get => GetArgument<TerraformValue<string>>("destination_connection_profile");
        set => SetArgument("destination_connection_profile", value);
    }

    /// <summary>
    /// BigqueryDestinationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDestinationConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock>? BigqueryDestinationConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock>>("bigquery_destination_config");
        set => SetArgument("bigquery_destination_config", value);
    }

    /// <summary>
    /// GcsDestinationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsDestinationConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlock>? GcsDestinationConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlock>>("gcs_destination_config");
        set => SetArgument("gcs_destination_config", value);
    }

}

/// <summary>
/// Block type for bigquery_destination_config in GoogleDatastreamStreamDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_destination_config";

    /// <summary>
    /// The guaranteed data freshness (in seconds) when querying tables created by the stream.
    /// Editing this field will only affect new tables created in the future, but existing tables
    /// will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Defaults to 900s.
    /// </summary>
    public TerraformValue<string>? DataFreshness
    {
        get => GetArgument<TerraformValue<string>>("data_freshness");
        set => SetArgument("data_freshness", value);
    }

    /// <summary>
    /// AppendOnly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppendOnly block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockAppendOnlyBlock>? AppendOnly
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockAppendOnlyBlock>>("append_only");
        set => SetArgument("append_only", value);
    }

    /// <summary>
    /// BlmtConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlmtConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockBlmtConfigBlock>? BlmtConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockBlmtConfigBlock>>("blmt_config");
        set => SetArgument("blmt_config", value);
    }

    /// <summary>
    /// Merge block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Merge block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockMergeBlock>? Merge
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockMergeBlock>>("merge");
        set => SetArgument("merge", value);
    }

    /// <summary>
    /// SingleTargetDataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleTargetDataset block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSingleTargetDatasetBlock>? SingleTargetDataset
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSingleTargetDatasetBlock>>("single_target_dataset");
        set => SetArgument("single_target_dataset", value);
    }

    /// <summary>
    /// SourceHierarchyDatasets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceHierarchyDatasets block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlock>? SourceHierarchyDatasets
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlock>>("source_hierarchy_datasets");
        set => SetArgument("source_hierarchy_datasets", value);
    }

}

/// <summary>
/// Block type for append_only in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockAppendOnlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "append_only";

}

/// <summary>
/// Block type for blmt_config in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockBlmtConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blmt_config";

    /// <summary>
    /// The Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bigquery connection. Format: &#39;{project}.{location}.{name}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    public required TerraformValue<string> ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The file format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileFormat is required")]
    public required TerraformValue<string> FileFormat
    {
        get => GetArgument<TerraformValue<string>>("file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The root path inside the Cloud Storage bucket.
    /// </summary>
    public TerraformValue<string>? RootPath
    {
        get => GetArgument<TerraformValue<string>>("root_path");
        set => SetArgument("root_path", value);
    }

    /// <summary>
    /// The table format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableFormat is required")]
    public required TerraformValue<string> TableFormat
    {
        get => GetArgument<TerraformValue<string>>("table_format");
        set => SetArgument("table_format", value);
    }

}

/// <summary>
/// Block type for merge in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockMergeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "merge";

}

/// <summary>
/// Block type for single_target_dataset in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSingleTargetDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_target_dataset";

    /// <summary>
    /// Dataset ID in the format projects/{project}/datasets/{dataset_id} or
    /// {project}:{dataset_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

}

/// <summary>
/// Block type for source_hierarchy_datasets in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_hierarchy_datasets";

    /// <summary>
    /// Optional. The project id of the BigQuery dataset. If not specified, the project will be inferred from the stream resource.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// DatasetTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatasetTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatasetTemplate block(s) allowed")]
    public required TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlockDatasetTemplateBlock> DatasetTemplate
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlockDatasetTemplateBlock>>("dataset_template");
        set => SetArgument("dataset_template", value);
    }

}

/// <summary>
/// Block type for dataset_template in GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockBigqueryDestinationConfigBlockSourceHierarchyDatasetsBlockDatasetTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset_template";

    /// <summary>
    /// If supplied, every created dataset will have its name prefixed by the provided value.
    /// The prefix and name will be separated by an underscore. i.e. _.
    /// </summary>
    public TerraformValue<string>? DatasetIdPrefix
    {
        get => GetArgument<TerraformValue<string>>("dataset_id_prefix");
        set => SetArgument("dataset_id_prefix", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery
    /// table. The BigQuery Service Account associated with your project requires access to this
    /// encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}.
    /// See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

}

/// <summary>
/// Block type for gcs_destination_config in GoogleDatastreamStreamDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_destination_config";

    /// <summary>
    /// The maximum duration for which new events are added before a file is closed and a new file is created.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Defaults to 900s.
    /// </summary>
    public TerraformValue<string>? FileRotationInterval
    {
        get => GetArgument<TerraformValue<string>>("file_rotation_interval");
        set => SetArgument("file_rotation_interval", value);
    }

    /// <summary>
    /// The maximum file size to be saved in the bucket.
    /// </summary>
    public TerraformValue<double>? FileRotationMb
    {
        get => GetArgument<TerraformValue<double>>("file_rotation_mb");
        set => SetArgument("file_rotation_mb", value);
    }

    /// <summary>
    /// Path inside the Cloud Storage bucket to write data to.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// AvroFileFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvroFileFormat block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockAvroFileFormatBlock>? AvroFileFormat
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockAvroFileFormatBlock>>("avro_file_format");
        set => SetArgument("avro_file_format", value);
    }

    /// <summary>
    /// JsonFileFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonFileFormat block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockJsonFileFormatBlock>? JsonFileFormat
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockJsonFileFormatBlock>>("json_file_format");
        set => SetArgument("json_file_format", value);
    }

}

/// <summary>
/// Block type for avro_file_format in GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockAvroFileFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro_file_format";

}

/// <summary>
/// Block type for json_file_format in GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlockGcsDestinationConfigBlockJsonFileFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_file_format";

    /// <summary>
    /// Compression of the loaded JSON file. Possible values: [&amp;quot;NO_COMPRESSION&amp;quot;, &amp;quot;GZIP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => GetArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The schema file format along JSON data files. Possible values: [&amp;quot;NO_SCHEMA_FILE&amp;quot;, &amp;quot;AVRO_SCHEMA_FILE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SchemaFileFormat
    {
        get => GetArgument<TerraformValue<string>>("schema_file_format");
        set => SetArgument("schema_file_format", value);
    }

}


/// <summary>
/// Block type for source_config in GoogleDatastreamStream.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_config";

    /// <summary>
    /// Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConnectionProfile is required")]
    public required TerraformValue<string> SourceConnectionProfile
    {
        get => GetArgument<TerraformValue<string>>("source_connection_profile");
        set => SetArgument("source_connection_profile", value);
    }

    /// <summary>
    /// MongodbSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlock>? MongodbSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlock>>("mongodb_source_config");
        set => SetArgument("mongodb_source_config", value);
    }

    /// <summary>
    /// MysqlSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock>? MysqlSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock>>("mysql_source_config");
        set => SetArgument("mysql_source_config", value);
    }

    /// <summary>
    /// OracleSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock>? OracleSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock>>("oracle_source_config");
        set => SetArgument("oracle_source_config", value);
    }

    /// <summary>
    /// PostgresqlSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresqlSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlock>? PostgresqlSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlock>>("postgresql_source_config");
        set => SetArgument("postgresql_source_config", value);
    }

    /// <summary>
    /// SalesforceSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SalesforceSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlock>? SalesforceSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlock>>("salesforce_source_config");
        set => SetArgument("salesforce_source_config", value);
    }

    /// <summary>
    /// SqlServerSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServerSourceConfig block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock>? SqlServerSourceConfig
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock>>("sql_server_source_config");
        set => SetArgument("sql_server_source_config", value);
    }

}

/// <summary>
/// Block type for mongodb_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mongodb_source_config";

    /// <summary>
    /// Optional. Maximum number of concurrent backfill tasks. The number
    /// should be non-negative and less than or equal to 50. If not set
    /// (or set to 0), the system&#39;&#39;s default value is used
    /// </summary>
    public TerraformValue<double>? MaxConcurrentBackfillTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_backfill_tasks");
        set => SetArgument("max_concurrent_backfill_tasks", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// Databases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlock>? Databases
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlock>>("databases");
        set => SetArgument("databases", value);
    }

}

/// <summary>
/// Block type for databases in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "databases";

    /// <summary>
    /// Database name.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Collections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlock>? Collections
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlock>>("collections");
        set => SetArgument("collections", value);
    }

}

/// <summary>
/// Block type for collections in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collections";

    /// <summary>
    /// Collection name.
    /// </summary>
    public TerraformValue<string>? Collection
    {
        get => GetArgument<TerraformValue<string>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockExcludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// Databases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlock>? Databases
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlock>>("databases");
        set => SetArgument("databases", value);
    }

}

/// <summary>
/// Block type for databases in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "databases";

    /// <summary>
    /// Database name.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Collections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlock>? Collections
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlock>>("collections");
        set => SetArgument("collections", value);
    }

}

/// <summary>
/// Block type for collections in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collections";

    /// <summary>
    /// Collection name.
    /// </summary>
    public TerraformValue<string>? Collection
    {
        get => GetArgument<TerraformValue<string>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMongodbSourceConfigBlockIncludeObjectsBlockDatabasesBlockCollectionsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

}

/// <summary>
/// Block type for mysql_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_source_config";

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non negative.
    /// If not set (or set to 0), the system&#39;s default value will be used.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentBackfillTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_backfill_tasks");
        set => SetArgument("max_concurrent_backfill_tasks", value);
    }

    /// <summary>
    /// Maximum number of concurrent CDC tasks. The number should be non negative.
    /// If not set (or set to 0), the system&#39;s default value will be used.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCdcTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_cdc_tasks");
        set => SetArgument("max_concurrent_cdc_tasks", value);
    }

    /// <summary>
    /// BinaryLogPosition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryLogPosition block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockBinaryLogPositionBlock>? BinaryLogPosition
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockBinaryLogPositionBlock>>("binary_log_position");
        set => SetArgument("binary_log_position", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// Gtid block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gtid block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockGtidBlock>? Gtid
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockGtidBlock>>("gtid");
        set => SetArgument("gtid", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

}

/// <summary>
/// Block type for binary_log_position in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockBinaryLogPositionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_log_position";

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// MysqlDatabases block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MysqlDatabases is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MysqlDatabases block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlock> MysqlDatabases
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlock>>("mysql_databases");
        set => SetArgument("mysql_databases", value);
    }

}

/// <summary>
/// Block type for mysql_databases in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_databases";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// MysqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>? MysqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>>("mysql_tables");
        set => SetArgument("mysql_tables", value);
    }

}

/// <summary>
/// Block type for mysql_tables in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// MysqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>? MysqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>>("mysql_columns");
        set => SetArgument("mysql_columns", value);
    }

}

/// <summary>
/// Block type for mysql_columns in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockExcludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_columns";

    /// <summary>
    /// Column collation.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => GetArgument<TerraformValue<string>>("collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for gtid in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockGtidBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gtid";

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// MysqlDatabases block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MysqlDatabases is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MysqlDatabases block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlock> MysqlDatabases
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlock>>("mysql_databases");
        set => SetArgument("mysql_databases", value);
    }

}

/// <summary>
/// Block type for mysql_databases in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_databases";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// MysqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>? MysqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock>>("mysql_tables");
        set => SetArgument("mysql_tables", value);
    }

}

/// <summary>
/// Block type for mysql_tables in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// MysqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>? MysqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock>>("mysql_columns");
        set => SetArgument("mysql_columns", value);
    }

}

/// <summary>
/// Block type for mysql_columns in GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockMysqlSourceConfigBlockIncludeObjectsBlockMysqlDatabasesBlockMysqlTablesBlockMysqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_columns";

    /// <summary>
    /// Column collation.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => GetArgument<TerraformValue<string>>("collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for oracle_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_source_config";

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non negative.
    /// If not set (or set to 0), the system&#39;s default value will be used.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentBackfillTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_backfill_tasks");
        set => SetArgument("max_concurrent_backfill_tasks", value);
    }

    /// <summary>
    /// Maximum number of concurrent CDC tasks. The number should be non negative.
    /// If not set (or set to 0), the system&#39;s default value will be used.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCdcTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_cdc_tasks");
        set => SetArgument("max_concurrent_cdc_tasks", value);
    }

    /// <summary>
    /// DropLargeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DropLargeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockDropLargeObjectsBlock>? DropLargeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockDropLargeObjectsBlock>>("drop_large_objects");
        set => SetArgument("drop_large_objects", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

    /// <summary>
    /// StreamLargeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamLargeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockStreamLargeObjectsBlock>? StreamLargeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockStreamLargeObjectsBlock>>("stream_large_objects");
        set => SetArgument("stream_large_objects", value);
    }

}

/// <summary>
/// Block type for drop_large_objects in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockDropLargeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "drop_large_objects";

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// OracleSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OracleSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OracleSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlock> OracleSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlock>>("oracle_schemas");
        set => SetArgument("oracle_schemas", value);
    }

}

/// <summary>
/// Block type for oracle_schemas in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// OracleTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlock>? OracleTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlock>>("oracle_tables");
        set => SetArgument("oracle_tables", value);
    }

}

/// <summary>
/// Block type for oracle_tables in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// OracleColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>? OracleColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>>("oracle_columns");
        set => SetArgument("oracle_columns", value);
    }

}

/// <summary>
/// Block type for oracle_columns in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockExcludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column encoding.
    /// </summary>
    public TerraformValue<string> Encoding
        => AsReference("encoding");

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// OracleSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OracleSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OracleSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlock> OracleSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlock>>("oracle_schemas");
        set => SetArgument("oracle_schemas", value);
    }

}

/// <summary>
/// Block type for oracle_schemas in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// OracleTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlock>? OracleTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlock>>("oracle_tables");
        set => SetArgument("oracle_tables", value);
    }

}

/// <summary>
/// Block type for oracle_tables in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// OracleColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>? OracleColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock>>("oracle_columns");
        set => SetArgument("oracle_columns", value);
    }

}

/// <summary>
/// Block type for oracle_columns in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockIncludeObjectsBlockOracleSchemasBlockOracleTablesBlockOracleColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column encoding.
    /// </summary>
    public TerraformValue<string> Encoding
        => AsReference("encoding");

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for stream_large_objects in GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockOracleSourceConfigBlockStreamLargeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stream_large_objects";

}

/// <summary>
/// Block type for postgresql_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_source_config";

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non
    /// negative. If not set (or set to 0), the system&#39;s default value will be used.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentBackfillTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_backfill_tasks");
        set => SetArgument("max_concurrent_backfill_tasks", value);
    }

    /// <summary>
    /// The name of the publication that includes the set of all tables
    /// that are defined in the stream&#39;s include_objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publication is required")]
    public required TerraformValue<string> Publication
    {
        get => GetArgument<TerraformValue<string>>("publication");
        set => SetArgument("publication", value);
    }

    /// <summary>
    /// The name of the logical replication slot that&#39;s configured with
    /// the pgoutput plugin.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSlot is required")]
    public required TerraformValue<string> ReplicationSlot
    {
        get => GetArgument<TerraformValue<string>>("replication_slot");
        set => SetArgument("replication_slot", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// PostgresqlSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostgresqlSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostgresqlSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlock> PostgresqlSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlock>>("postgresql_schemas");
        set => SetArgument("postgresql_schemas", value);
    }

}

/// <summary>
/// Block type for postgresql_schemas in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_schemas";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// PostgresqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>? PostgresqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>>("postgresql_tables");
        set => SetArgument("postgresql_tables", value);
    }

}

/// <summary>
/// Block type for postgresql_tables in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// PostgresqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>? PostgresqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>>("postgresql_columns");
        set => SetArgument("postgresql_columns", value);
    }

}

/// <summary>
/// Block type for postgresql_columns in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockExcludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// PostgresqlSchemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostgresqlSchemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostgresqlSchemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlock> PostgresqlSchemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlock>>("postgresql_schemas");
        set => SetArgument("postgresql_schemas", value);
    }

}

/// <summary>
/// Block type for postgresql_schemas in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_schemas";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// PostgresqlTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>? PostgresqlTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock>>("postgresql_tables");
        set => SetArgument("postgresql_tables", value);
    }

}

/// <summary>
/// Block type for postgresql_tables in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// PostgresqlColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>? PostgresqlColumns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock>>("postgresql_columns");
        set => SetArgument("postgresql_columns", value);
    }

}

/// <summary>
/// Block type for postgresql_columns in GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockPostgresqlSourceConfigBlockIncludeObjectsBlockPostgresqlSchemasBlockPostgresqlTablesBlockPostgresqlColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double>? OrdinalPosition
    {
        get => GetArgument<TerraformValue<double>>("ordinal_position");
        set => SetArgument("ordinal_position", value);
    }

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool>? PrimaryKey
    {
        get => GetArgument<TerraformValue<bool>>("primary_key");
        set => SetArgument("primary_key", value);
    }

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for salesforce_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce_source_config";

    /// <summary>
    /// Salesforce objects polling interval. The interval at which new changes will be polled for each object. The duration must be between 5 minutes and 24 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PollingInterval is required")]
    public required TerraformValue<string> PollingInterval
    {
        get => GetArgument<TerraformValue<string>>("polling_interval");
        set => SetArgument("polling_interval", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// Objects block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Objects is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Objects block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlock> Objects
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlock>>("objects");
        set => SetArgument("objects", value);
    }

}

/// <summary>
/// Block type for objects in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "objects";

    /// <summary>
    /// Name of object in Salesforce Org.
    /// </summary>
    public TerraformValue<string>? ObjectName
    {
        get => GetArgument<TerraformValue<string>>("object_name");
        set => SetArgument("object_name", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockExcludeObjectsBlockObjectsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// Objects block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Objects is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Objects block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlock> Objects
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlock>>("objects");
        set => SetArgument("objects", value);
    }

}

/// <summary>
/// Block type for objects in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "objects";

    /// <summary>
    /// Name of object in Salesforce Org.
    /// </summary>
    public TerraformValue<string>? ObjectName
    {
        get => GetArgument<TerraformValue<string>>("object_name");
        set => SetArgument("object_name", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlockFieldsBlock>? Fields
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSalesforceSourceConfigBlockIncludeObjectsBlockObjectsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Field name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for sql_server_source_config in GoogleDatastreamStreamSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_server_source_config";

    /// <summary>
    /// Max concurrent backfill tasks.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentBackfillTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_backfill_tasks");
        set => SetArgument("max_concurrent_backfill_tasks", value);
    }

    /// <summary>
    /// Max concurrent CDC tasks.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCdcTasks
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_cdc_tasks");
        set => SetArgument("max_concurrent_cdc_tasks", value);
    }

    /// <summary>
    /// ChangeTables block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChangeTables block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockChangeTablesBlock>? ChangeTables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockChangeTablesBlock>>("change_tables");
        set => SetArgument("change_tables", value);
    }

    /// <summary>
    /// ExcludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlock>? ExcludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlock>>("exclude_objects");
        set => SetArgument("exclude_objects", value);
    }

    /// <summary>
    /// IncludeObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeObjects block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlock>? IncludeObjects
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlock>>("include_objects");
        set => SetArgument("include_objects", value);
    }

    /// <summary>
    /// TransactionLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransactionLogs block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockTransactionLogsBlock>? TransactionLogs
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockTransactionLogsBlock>>("transaction_logs");
        set => SetArgument("transaction_logs", value);
    }

}

/// <summary>
/// Block type for change_tables in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockChangeTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "change_tables";

}

/// <summary>
/// Block type for exclude_objects in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_objects";

    /// <summary>
    /// Schemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlock> Schemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlock>>("schemas");
        set => SetArgument("schemas", value);
    }

}

/// <summary>
/// Block type for schemas in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Tables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlock>? Tables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlock>>("tables");
        set => SetArgument("tables", value);
    }

}

/// <summary>
/// Block type for tables in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// Columns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

}

/// <summary>
/// Block type for columns in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockExcludeObjectsBlockSchemasBlockTablesBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The SQL Server data type. Full data types list can be found here:
    /// https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for include_objects in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_objects";

    /// <summary>
    /// Schemas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schemas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schemas block(s) required")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlock> Schemas
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlock>>("schemas");
        set => SetArgument("schemas", value);
    }

}

/// <summary>
/// Block type for schemas in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schemas";

    /// <summary>
    /// Schema name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Tables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlock>? Tables
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlock>>("tables");
        set => SetArgument("tables", value);
    }

}

/// <summary>
/// Block type for tables in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tables";

    /// <summary>
    /// Table name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// Columns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

}

/// <summary>
/// Block type for columns in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockIncludeObjectsBlockSchemasBlockTablesBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// Column name.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The SQL Server data type. Full data types list can be found here:
    /// https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
    /// </summary>
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Column length.
    /// </summary>
    public TerraformValue<double> Length
        => AsReference("length");

    /// <summary>
    /// Whether or not the column can accept a null value.
    /// </summary>
    public TerraformValue<bool> Nullable
        => AsReference("nullable");

    /// <summary>
    /// The ordinal position of the column in the table.
    /// </summary>
    public TerraformValue<double> OrdinalPosition
        => AsReference("ordinal_position");

    /// <summary>
    /// Column precision.
    /// </summary>
    public TerraformValue<double> Precision
        => AsReference("precision");

    /// <summary>
    /// Whether or not the column represents a primary key.
    /// </summary>
    public TerraformValue<bool> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// Column scale.
    /// </summary>
    public TerraformValue<double> Scale
        => AsReference("scale");

}

/// <summary>
/// Block type for transaction_logs in GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlockSqlServerSourceConfigBlockTransactionLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transaction_logs";

}


/// <summary>
/// Block type for timeouts in GoogleDatastreamStream.
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamStreamTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_datastream_stream Terraform resource.
/// Manages a google_datastream_stream resource.
/// </summary>
public partial class GoogleDatastreamStream(string name) : TerraformResource("google_datastream_stream", name)
{
    /// <summary>
    /// Create the stream without validating it.
    /// </summary>
    public TerraformValue<bool>? CreateWithoutValidation
    {
        get => GetArgument<TerraformValue<bool>>("create_without_validation");
        set => SetArgument("create_without_validation", value);
    }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    public TerraformValue<string>? CustomerManagedEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_encryption_key");
        set => SetArgument("customer_managed_encryption_key", value);
    }

    /// <summary>
    /// Desired state of the Stream. Set this field to &#39;RUNNING&#39; to start the stream,
    /// &#39;NOT_STARTED&#39; to create the stream without starting and &#39;PAUSED&#39; to pause
    /// the stream from a &#39;RUNNING&#39; state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the location this stream is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The stream identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamId is required")]
    public required TerraformValue<string> StreamId
    {
        get => GetArgument<TerraformValue<string>>("stream_id");
        set => SetArgument("stream_id", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The stream&#39;s name.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The state of the stream.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// BackfillAll block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillAll block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlock>? BackfillAll
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillAllBlock>>("backfill_all");
        set => SetArgument("backfill_all", value);
    }

    /// <summary>
    /// BackfillNone block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillNone block(s) allowed")]
    public TerraformList<GoogleDatastreamStreamBackfillNoneBlock>? BackfillNone
    {
        get => GetArgument<TerraformList<GoogleDatastreamStreamBackfillNoneBlock>>("backfill_none");
        set => SetArgument("backfill_none", value);
    }

    /// <summary>
    /// DestinationConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public required TerraformList<GoogleDatastreamStreamDestinationConfigBlock> DestinationConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamDestinationConfigBlock>>("destination_config");
        set => SetArgument("destination_config", value);
    }

    /// <summary>
    /// SourceConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfig block(s) allowed")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlock> SourceConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDatastreamStreamSourceConfigBlock>>("source_config");
        set => SetArgument("source_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDatastreamStreamTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDatastreamStreamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
