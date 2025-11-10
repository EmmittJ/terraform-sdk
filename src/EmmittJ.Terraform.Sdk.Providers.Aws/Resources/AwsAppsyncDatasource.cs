using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dynamodb_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceDynamodbConfigBlock : TerraformBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => WithProperty("table_name", value);
    }

    /// <summary>
    /// The use_caller_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCallerCredentials
    {
        get => GetProperty<TerraformProperty<bool>>("use_caller_credentials");
        set => WithProperty("use_caller_credentials", value);
    }

    /// <summary>
    /// The versioned attribute.
    /// </summary>
    public TerraformProperty<bool>? Versioned
    {
        get => GetProperty<TerraformProperty<bool>>("versioned");
        set => WithProperty("versioned", value);
    }

}

/// <summary>
/// Block type for elasticsearch_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceElasticsearchConfigBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformProperty<string> Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Block type for event_bridge_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceEventBridgeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    public required TerraformProperty<string> EventBusArn
    {
        get => GetProperty<TerraformProperty<string>>("event_bus_arn");
        set => WithProperty("event_bus_arn", value);
    }

}

/// <summary>
/// Block type for http_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceHttpConfigBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformProperty<string> Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformProperty<string> FunctionArn
    {
        get => GetProperty<TerraformProperty<string>>("function_arn");
        set => WithProperty("function_arn", value);
    }

}

/// <summary>
/// Block type for opensearchservice_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceOpensearchserviceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformProperty<string> Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Block type for relational_database_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceRelationalDatabaseConfigBlock : TerraformBlock
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformProperty<string>? SourceType
    {
        get => GetProperty<TerraformProperty<string>>("source_type");
        set => WithProperty("source_type", value);
    }

}

/// <summary>
/// Manages a aws_appsync_datasource resource.
/// </summary>
public class AwsAppsyncDatasource : TerraformResource
{
    public AwsAppsyncDatasource(string name) : base("aws_appsync_datasource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_role_arn");
        set => this.WithProperty("service_role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for dynamodb_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceDynamodbConfigBlock>? DynamodbConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceDynamodbConfigBlock>>("dynamodb_config");
        set => this.WithProperty("dynamodb_config", value);
    }

    /// <summary>
    /// Block for elasticsearch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceElasticsearchConfigBlock>? ElasticsearchConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceElasticsearchConfigBlock>>("elasticsearch_config");
        set => this.WithProperty("elasticsearch_config", value);
    }

    /// <summary>
    /// Block for event_bridge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceEventBridgeConfigBlock>? EventBridgeConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceEventBridgeConfigBlock>>("event_bridge_config");
        set => this.WithProperty("event_bridge_config", value);
    }

    /// <summary>
    /// Block for http_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceHttpConfigBlock>? HttpConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceHttpConfigBlock>>("http_config");
        set => this.WithProperty("http_config", value);
    }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceLambdaConfigBlock>? LambdaConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceLambdaConfigBlock>>("lambda_config");
        set => this.WithProperty("lambda_config", value);
    }

    /// <summary>
    /// Block for opensearchservice_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserviceConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceOpensearchserviceConfigBlock>? OpensearchserviceConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceOpensearchserviceConfigBlock>>("opensearchservice_config");
        set => this.WithProperty("opensearchservice_config", value);
    }

    /// <summary>
    /// Block for relational_database_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalDatabaseConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>? RelationalDatabaseConfig
    {
        get => GetProperty<List<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>>("relational_database_config");
        set => this.WithProperty("relational_database_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
