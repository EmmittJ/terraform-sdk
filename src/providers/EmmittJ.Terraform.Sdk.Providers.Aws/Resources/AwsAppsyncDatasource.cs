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
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// The use_caller_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCallerCredentials
    {
        set => SetProperty("use_caller_credentials", value);
    }

    /// <summary>
    /// The versioned attribute.
    /// </summary>
    public TerraformProperty<bool>? Versioned
    {
        set => SetProperty("versioned", value);
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
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
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
        set => SetProperty("event_bus_arn", value);
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
        set => SetProperty("endpoint", value);
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
        set => SetProperty("function_arn", value);
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
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
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
        set => SetProperty("source_type", value);
    }

}

/// <summary>
/// Manages a aws_appsync_datasource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncDatasource : TerraformResource
{
    public AwsAppsyncDatasource(string name) : base("aws_appsync_datasource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("api_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("service_role_arn");
        SetOutput("type");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ServiceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role_arn");
        set => SetProperty("service_role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for dynamodb_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceDynamodbConfigBlock>? DynamodbConfig
    {
        set => SetProperty("dynamodb_config", value);
    }

    /// <summary>
    /// Block for elasticsearch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceElasticsearchConfigBlock>? ElasticsearchConfig
    {
        set => SetProperty("elasticsearch_config", value);
    }

    /// <summary>
    /// Block for event_bridge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceEventBridgeConfigBlock>? EventBridgeConfig
    {
        set => SetProperty("event_bridge_config", value);
    }

    /// <summary>
    /// Block for http_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceHttpConfigBlock>? HttpConfig
    {
        set => SetProperty("http_config", value);
    }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceLambdaConfigBlock>? LambdaConfig
    {
        set => SetProperty("lambda_config", value);
    }

    /// <summary>
    /// Block for opensearchservice_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserviceConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceOpensearchserviceConfigBlock>? OpensearchserviceConfig
    {
        set => SetProperty("opensearchservice_config", value);
    }

    /// <summary>
    /// Block for relational_database_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalDatabaseConfig block(s) allowed")]
    public List<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>? RelationalDatabaseConfig
    {
        set => SetProperty("relational_database_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
