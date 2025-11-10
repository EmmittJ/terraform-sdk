using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dynamodb_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceDynamodbConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "region");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

    /// <summary>
    /// The use_caller_credentials attribute.
    /// </summary>
    [TerraformPropertyName("use_caller_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCallerCredentials { get; set; }

    /// <summary>
    /// The versioned attribute.
    /// </summary>
    [TerraformPropertyName("versioned")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Versioned { get; set; }

}

/// <summary>
/// Block type for elasticsearch_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceElasticsearchConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Endpoint { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "region");

}

/// <summary>
/// Block type for event_bridge_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceEventBridgeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    [TerraformPropertyName("event_bus_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventBusArn { get; set; }

}

/// <summary>
/// Block type for http_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceHttpConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Endpoint { get; set; }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceLambdaConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformPropertyName("function_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionArn { get; set; }

}

/// <summary>
/// Block type for opensearchservice_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceOpensearchserviceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Endpoint { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "region");

}

/// <summary>
/// Block type for relational_database_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncDatasourceRelationalDatabaseConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformPropertyName("source_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceType { get; set; }

}

/// <summary>
/// Manages a aws_appsync_datasource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncDatasource : TerraformResource
{
    public AwsAppsyncDatasource(string name) : base("aws_appsync_datasource", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceRoleArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for dynamodb_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbConfig block(s) allowed")]
    [TerraformPropertyName("dynamodb_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceDynamodbConfigBlock>>? DynamodbConfig { get; set; } = new();

    /// <summary>
    /// Block for elasticsearch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfig block(s) allowed")]
    [TerraformPropertyName("elasticsearch_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceElasticsearchConfigBlock>>? ElasticsearchConfig { get; set; } = new();

    /// <summary>
    /// Block for event_bridge_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeConfig block(s) allowed")]
    [TerraformPropertyName("event_bridge_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceEventBridgeConfigBlock>>? EventBridgeConfig { get; set; } = new();

    /// <summary>
    /// Block for http_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpConfig block(s) allowed")]
    [TerraformPropertyName("http_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceHttpConfigBlock>>? HttpConfig { get; set; } = new();

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    [TerraformPropertyName("lambda_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceLambdaConfigBlock>>? LambdaConfig { get; set; } = new();

    /// <summary>
    /// Block for opensearchservice_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserviceConfig block(s) allowed")]
    [TerraformPropertyName("opensearchservice_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceOpensearchserviceConfigBlock>>? OpensearchserviceConfig { get; set; } = new();

    /// <summary>
    /// Block for relational_database_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalDatabaseConfig block(s) allowed")]
    [TerraformPropertyName("relational_database_config")]
    public TerraformList<TerraformBlock<AwsAppsyncDatasourceRelationalDatabaseConfigBlock>>? RelationalDatabaseConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
