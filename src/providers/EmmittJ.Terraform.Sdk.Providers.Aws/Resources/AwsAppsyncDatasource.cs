using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dynamodb_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceDynamodbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodb_config";

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The use_caller_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? UseCallerCredentials
    {
        get => GetArgument<TerraformValue<bool>>("use_caller_credentials");
        set => SetArgument("use_caller_credentials", value);
    }

    /// <summary>
    /// The versioned attribute.
    /// </summary>
    public TerraformValue<bool>? Versioned
    {
        get => GetArgument<TerraformValue<bool>>("versioned");
        set => SetArgument("versioned", value);
    }

    /// <summary>
    /// DeltaSyncConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeltaSyncConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceDynamodbConfigBlockDeltaSyncConfigBlock>? DeltaSyncConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceDynamodbConfigBlockDeltaSyncConfigBlock>>("delta_sync_config");
        set => SetArgument("delta_sync_config", value);
    }

}

/// <summary>
/// Block type for delta_sync_config in AwsAppsyncDatasourceDynamodbConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceDynamodbConfigBlockDeltaSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delta_sync_config";

    /// <summary>
    /// The base_table_ttl attribute.
    /// </summary>
    public TerraformValue<double>? BaseTableTtl
    {
        get => GetArgument<TerraformValue<double>>("base_table_ttl");
        set => SetArgument("base_table_ttl", value);
    }

    /// <summary>
    /// The delta_sync_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaSyncTableName is required")]
    public required TerraformValue<string> DeltaSyncTableName
    {
        get => GetArgument<TerraformValue<string>>("delta_sync_table_name");
        set => SetArgument("delta_sync_table_name", value);
    }

    /// <summary>
    /// The delta_sync_table_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DeltaSyncTableTtl
    {
        get => GetArgument<TerraformValue<double>>("delta_sync_table_ttl");
        set => SetArgument("delta_sync_table_ttl", value);
    }

}


/// <summary>
/// Block type for elasticsearch_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceElasticsearchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticsearch_config";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for event_bridge_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceEventBridgeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_bridge_config";

    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    public required TerraformValue<string> EventBusArn
    {
        get => GetArgument<TerraformValue<string>>("event_bus_arn");
        set => SetArgument("event_bus_arn", value);
    }

}


/// <summary>
/// Block type for http_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceHttpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_config";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// AuthorizationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizationConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlock>? AuthorizationConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlock>>("authorization_config");
        set => SetArgument("authorization_config", value);
    }

}

/// <summary>
/// Block type for authorization_config in AwsAppsyncDatasourceHttpConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization_config";

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationType
    {
        get => GetArgument<TerraformValue<string>>("authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// AwsIamConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsIamConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlockAwsIamConfigBlock>? AwsIamConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlockAwsIamConfigBlock>>("aws_iam_config");
        set => SetArgument("aws_iam_config", value);
    }

}

/// <summary>
/// Block type for aws_iam_config in AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceHttpConfigBlockAuthorizationConfigBlockAwsIamConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_iam_config";

    /// <summary>
    /// The signing_region attribute.
    /// </summary>
    public TerraformValue<string>? SigningRegion
    {
        get => GetArgument<TerraformValue<string>>("signing_region");
        set => SetArgument("signing_region", value);
    }

    /// <summary>
    /// The signing_service_name attribute.
    /// </summary>
    public TerraformValue<string>? SigningServiceName
    {
        get => GetArgument<TerraformValue<string>>("signing_service_name");
        set => SetArgument("signing_service_name", value);
    }

}


/// <summary>
/// Block type for lambda_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_config";

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => GetArgument<TerraformValue<string>>("function_arn");
        set => SetArgument("function_arn", value);
    }

}


/// <summary>
/// Block type for opensearchservice_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceOpensearchserviceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "opensearchservice_config";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for relational_database_config in AwsAppsyncDatasource.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceRelationalDatabaseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "relational_database_config";

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformValue<string>? SourceType
    {
        get => GetArgument<TerraformValue<string>>("source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// HttpEndpointConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceRelationalDatabaseConfigBlockHttpEndpointConfigBlock>? HttpEndpointConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceRelationalDatabaseConfigBlockHttpEndpointConfigBlock>>("http_endpoint_config");
        set => SetArgument("http_endpoint_config", value);
    }

}

/// <summary>
/// Block type for http_endpoint_config in AwsAppsyncDatasourceRelationalDatabaseConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceRelationalDatabaseConfigBlockHttpEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_endpoint_config";

    /// <summary>
    /// The aws_secret_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsSecretStoreArn is required")]
    public required TerraformValue<string> AwsSecretStoreArn
    {
        get => GetArgument<TerraformValue<string>>("aws_secret_store_arn");
        set => SetArgument("aws_secret_store_arn", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformValue<string> DbClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_cluster_identifier");
        set => SetArgument("db_cluster_identifier", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string>? Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

}


/// <summary>
/// Represents a aws_appsync_datasource Terraform resource.
/// Manages a aws_appsync_datasource resource.
/// </summary>
public partial class AwsAppsyncDatasource(string name) : TerraformResource("aws_appsync_datasource", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceRoleArn
    {
        get => GetArgument<TerraformValue<string>>("service_role_arn");
        set => SetArgument("service_role_arn", value);
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
    /// DynamodbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceDynamodbConfigBlock>? DynamodbConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceDynamodbConfigBlock>>("dynamodb_config");
        set => SetArgument("dynamodb_config", value);
    }

    /// <summary>
    /// ElasticsearchConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceElasticsearchConfigBlock>? ElasticsearchConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceElasticsearchConfigBlock>>("elasticsearch_config");
        set => SetArgument("elasticsearch_config", value);
    }

    /// <summary>
    /// EventBridgeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceEventBridgeConfigBlock>? EventBridgeConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceEventBridgeConfigBlock>>("event_bridge_config");
        set => SetArgument("event_bridge_config", value);
    }

    /// <summary>
    /// HttpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceHttpConfigBlock>? HttpConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceHttpConfigBlock>>("http_config");
        set => SetArgument("http_config", value);
    }

    /// <summary>
    /// LambdaConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceLambdaConfigBlock>? LambdaConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceLambdaConfigBlock>>("lambda_config");
        set => SetArgument("lambda_config", value);
    }

    /// <summary>
    /// OpensearchserviceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserviceConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceOpensearchserviceConfigBlock>? OpensearchserviceConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceOpensearchserviceConfigBlock>>("opensearchservice_config");
        set => SetArgument("opensearchservice_config", value);
    }

    /// <summary>
    /// RelationalDatabaseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalDatabaseConfig block(s) allowed")]
    public TerraformList<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>? RelationalDatabaseConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>>("relational_database_config");
        set => SetArgument("relational_database_config", value);
    }

}
