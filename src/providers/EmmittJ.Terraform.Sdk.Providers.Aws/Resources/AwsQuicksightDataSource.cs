using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credentials in AwsQuicksightDataSource.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The copy_source_arn attribute.
    /// </summary>
    public TerraformValue<string>? CopySourceArn
    {
        get => GetArgument<TerraformValue<string>>("copy_source_arn");
        set => SetArgument("copy_source_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => GetArgument<TerraformValue<string>>("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// CredentialPair block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CredentialPair block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceCredentialsBlockCredentialPairBlock>? CredentialPair
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceCredentialsBlockCredentialPairBlock>>("credential_pair");
        set => SetArgument("credential_pair", value);
    }

}

/// <summary>
/// Block type for credential_pair in AwsQuicksightDataSourceCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceCredentialsBlockCredentialPairBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credential_pair";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for parameters in AwsQuicksightDataSource.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// AmazonElasticsearch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonElasticsearch block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockAmazonElasticsearchBlock>? AmazonElasticsearch
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockAmazonElasticsearchBlock>>("amazon_elasticsearch");
        set => SetArgument("amazon_elasticsearch", value);
    }

    /// <summary>
    /// Athena block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Athena block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockAthenaBlock>? Athena
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockAthenaBlock>>("athena");
        set => SetArgument("athena", value);
    }

    /// <summary>
    /// Aurora block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aurora block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockAuroraBlock>? Aurora
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockAuroraBlock>>("aurora");
        set => SetArgument("aurora", value);
    }

    /// <summary>
    /// AuroraPostgresql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuroraPostgresql block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockAuroraPostgresqlBlock>? AuroraPostgresql
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockAuroraPostgresqlBlock>>("aurora_postgresql");
        set => SetArgument("aurora_postgresql", value);
    }

    /// <summary>
    /// AwsIotAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsIotAnalytics block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockAwsIotAnalyticsBlock>? AwsIotAnalytics
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockAwsIotAnalyticsBlock>>("aws_iot_analytics");
        set => SetArgument("aws_iot_analytics", value);
    }

    /// <summary>
    /// Databricks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Databricks block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockDatabricksBlock>? Databricks
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockDatabricksBlock>>("databricks");
        set => SetArgument("databricks", value);
    }

    /// <summary>
    /// Jira block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Jira block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockJiraBlock>? Jira
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockJiraBlock>>("jira");
        set => SetArgument("jira", value);
    }

    /// <summary>
    /// MariaDb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MariaDb block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockMariaDbBlock>? MariaDb
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockMariaDbBlock>>("maria_db");
        set => SetArgument("maria_db", value);
    }

    /// <summary>
    /// Mysql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockMysqlBlock>? Mysql
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockMysqlBlock>>("mysql");
        set => SetArgument("mysql", value);
    }

    /// <summary>
    /// Oracle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockOracleBlock>? Oracle
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockOracleBlock>>("oracle");
        set => SetArgument("oracle", value);
    }

    /// <summary>
    /// Postgresql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockPostgresqlBlock>? Postgresql
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockPostgresqlBlock>>("postgresql");
        set => SetArgument("postgresql", value);
    }

    /// <summary>
    /// Presto block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Presto block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockPrestoBlock>? Presto
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockPrestoBlock>>("presto");
        set => SetArgument("presto", value);
    }

    /// <summary>
    /// Rds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rds block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockRdsBlock>? Rds
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockRdsBlock>>("rds");
        set => SetArgument("rds", value);
    }

    /// <summary>
    /// Redshift block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redshift block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockRedshiftBlock>? Redshift
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockRedshiftBlock>>("redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// ServiceNow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceNow block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockServiceNowBlock>? ServiceNow
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockServiceNowBlock>>("service_now");
        set => SetArgument("service_now", value);
    }

    /// <summary>
    /// Snowflake block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Snowflake block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockSnowflakeBlock>? Snowflake
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockSnowflakeBlock>>("snowflake");
        set => SetArgument("snowflake", value);
    }

    /// <summary>
    /// Spark block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockSparkBlock>? Spark
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockSparkBlock>>("spark");
        set => SetArgument("spark", value);
    }

    /// <summary>
    /// SqlServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlServer block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockSqlServerBlock>? SqlServer
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockSqlServerBlock>>("sql_server");
        set => SetArgument("sql_server", value);
    }

    /// <summary>
    /// Teradata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Teradata block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockTeradataBlock>? Teradata
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockTeradataBlock>>("teradata");
        set => SetArgument("teradata", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceParametersBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceParametersBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for amazon_elasticsearch in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockAmazonElasticsearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_elasticsearch";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

}

/// <summary>
/// Block type for athena in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockAthenaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "athena";

    /// <summary>
    /// The work_group attribute.
    /// </summary>
    public TerraformValue<string>? WorkGroup
    {
        get => GetArgument<TerraformValue<string>>("work_group");
        set => SetArgument("work_group", value);
    }

}

/// <summary>
/// Block type for aurora in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockAuroraBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aurora";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for aurora_postgresql in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockAuroraPostgresqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aurora_postgresql";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for aws_iot_analytics in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockAwsIotAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_iot_analytics";

    /// <summary>
    /// The data_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetName is required")]
    public required TerraformValue<string> DataSetName
    {
        get => GetArgument<TerraformValue<string>>("data_set_name");
        set => SetArgument("data_set_name", value);
    }

}

/// <summary>
/// Block type for databricks in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockDatabricksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "databricks";

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The sql_endpoint_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlEndpointPath is required")]
    public required TerraformValue<string> SqlEndpointPath
    {
        get => GetArgument<TerraformValue<string>>("sql_endpoint_path");
        set => SetArgument("sql_endpoint_path", value);
    }

}

/// <summary>
/// Block type for jira in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockJiraBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jira";

    /// <summary>
    /// The site_base_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteBaseUrl is required")]
    public required TerraformValue<string> SiteBaseUrl
    {
        get => GetArgument<TerraformValue<string>>("site_base_url");
        set => SetArgument("site_base_url", value);
    }

}

/// <summary>
/// Block type for maria_db in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockMariaDbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maria_db";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for mysql in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockMysqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for oracle in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockOracleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for postgresql in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockPostgresqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for presto in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockPrestoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "presto";

    /// <summary>
    /// The catalog attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Catalog is required")]
    public required TerraformValue<string> Catalog
    {
        get => GetArgument<TerraformValue<string>>("catalog");
        set => SetArgument("catalog", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for rds in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockRdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rds";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

}

/// <summary>
/// Block type for redshift in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockRedshiftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift";

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? ClusterId
    {
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for s3 in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// ManifestFileLocation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManifestFileLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManifestFileLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManifestFileLocation block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSourceParametersBlockS3BlockManifestFileLocationBlock> ManifestFileLocation
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSourceParametersBlockS3BlockManifestFileLocationBlock>>("manifest_file_location");
        set => SetArgument("manifest_file_location", value);
    }

}

/// <summary>
/// Block type for manifest_file_location in AwsQuicksightDataSourceParametersBlockS3Block.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockS3BlockManifestFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manifest_file_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for service_now in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockServiceNowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_now";

    /// <summary>
    /// The site_base_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteBaseUrl is required")]
    public required TerraformValue<string> SiteBaseUrl
    {
        get => GetArgument<TerraformValue<string>>("site_base_url");
        set => SetArgument("site_base_url", value);
    }

}

/// <summary>
/// Block type for snowflake in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockSnowflakeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The warehouse attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Warehouse is required")]
    public required TerraformValue<string> Warehouse
    {
        get => GetArgument<TerraformValue<string>>("warehouse");
        set => SetArgument("warehouse", value);
    }

}

/// <summary>
/// Block type for spark in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockSparkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark";

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for sql_server in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockSqlServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_server";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for teradata in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockTeradataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "teradata";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for twitter in AwsQuicksightDataSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlockTwitterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "twitter";

    /// <summary>
    /// The max_rows attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRows is required")]
    public required TerraformValue<double> MaxRows
    {
        get => GetArgument<TerraformValue<double>>("max_rows");
        set => SetArgument("max_rows", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

}


/// <summary>
/// Block type for permission in AwsQuicksightDataSource.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSourcePermissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permission";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => GetArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for ssl_properties in AwsQuicksightDataSource.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceSslPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_properties";

    /// <summary>
    /// The disable_ssl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableSsl is required")]
    public required TerraformValue<bool> DisableSsl
    {
        get => GetArgument<TerraformValue<bool>>("disable_ssl");
        set => SetArgument("disable_ssl", value);
    }

}


/// <summary>
/// Block type for vpc_connection_properties in AwsQuicksightDataSource.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceVpcConnectionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_connection_properties";

    /// <summary>
    /// The vpc_connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConnectionArn is required")]
    public required TerraformValue<string> VpcConnectionArn
    {
        get => GetArgument<TerraformValue<string>>("vpc_connection_arn");
        set => SetArgument("vpc_connection_arn", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_data_source Terraform resource.
/// Manages a aws_quicksight_data_source resource.
/// </summary>
public partial class AwsQuicksightDataSource(string name) : TerraformResource("aws_quicksight_data_source", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => GetArgument<TerraformValue<string>>("data_source_id");
        set => SetArgument("data_source_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceCredentialsBlock>? Credentials
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSourceParametersBlock> Parameters
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSourceParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Permission block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permission block(s) allowed")]
    public TerraformSet<AwsQuicksightDataSourcePermissionBlock>? Permission
    {
        get => GetArgument<TerraformSet<AwsQuicksightDataSourcePermissionBlock>>("permission");
        set => SetArgument("permission", value);
    }

    /// <summary>
    /// SslProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslProperties block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceSslPropertiesBlock>? SslProperties
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceSslPropertiesBlock>>("ssl_properties");
        set => SetArgument("ssl_properties", value);
    }

    /// <summary>
    /// VpcConnectionProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConnectionProperties block(s) allowed")]
    public TerraformList<AwsQuicksightDataSourceVpcConnectionPropertiesBlock>? VpcConnectionProperties
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSourceVpcConnectionPropertiesBlock>>("vpc_connection_properties");
        set => SetArgument("vpc_connection_properties", value);
    }

}
