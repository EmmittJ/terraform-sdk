using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dynamodb_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceDynamodbConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The use_caller_credentials attribute.
    /// </summary>
    [TerraformProperty("use_caller_credentials")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseCallerCredentials { get; set; }

    /// <summary>
    /// The versioned attribute.
    /// </summary>
    [TerraformProperty("versioned")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Versioned { get; set; }

}

/// <summary>
/// Block type for elasticsearch_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceElasticsearchConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for event_bridge_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceEventBridgeConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    [TerraformProperty("event_bus_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventBusArn { get; set; }

}

/// <summary>
/// Block type for http_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceHttpConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceLambdaConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformProperty("function_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionArn { get; set; }

}

/// <summary>
/// Block type for opensearchservice_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceOpensearchserviceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for relational_database_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncDatasourceRelationalDatabaseConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformProperty("source_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceType { get; set; }

}

/// <summary>
/// Manages a aws_appsync_datasource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppsyncDatasource : TerraformResource
{
    public AwsAppsyncDatasource(string name) : base("aws_appsync_datasource", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceRoleArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for dynamodb_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbConfig block(s) allowed")]
    [TerraformProperty("dynamodb_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceDynamodbConfigBlock>>? DynamodbConfig { get; set; }

    /// <summary>
    /// Block for elasticsearch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfig block(s) allowed")]
    [TerraformProperty("elasticsearch_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceElasticsearchConfigBlock>>? ElasticsearchConfig { get; set; }

    /// <summary>
    /// Block for event_bridge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeConfig block(s) allowed")]
    [TerraformProperty("event_bridge_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceEventBridgeConfigBlock>>? EventBridgeConfig { get; set; }

    /// <summary>
    /// Block for http_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfig block(s) allowed")]
    [TerraformProperty("http_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceHttpConfigBlock>>? HttpConfig { get; set; }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    [TerraformProperty("lambda_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceLambdaConfigBlock>>? LambdaConfig { get; set; }

    /// <summary>
    /// Block for opensearchservice_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserviceConfig block(s) allowed")]
    [TerraformProperty("opensearchservice_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceOpensearchserviceConfigBlock>>? OpensearchserviceConfig { get; set; }

    /// <summary>
    /// Block for relational_database_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalDatabaseConfig block(s) allowed")]
    [TerraformProperty("relational_database_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>>? RelationalDatabaseConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
