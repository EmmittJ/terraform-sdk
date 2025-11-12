using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_authentication_provider in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock() : TerraformBlock("additional_authentication_provider")
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationType { get; set; }

}

/// <summary>
/// Block type for enhanced_metrics_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock() : TerraformBlock("enhanced_metrics_config")
{
    /// <summary>
    /// The data_source_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceLevelMetricsBehavior is required")]
    [TerraformProperty("data_source_level_metrics_behavior")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>
    /// The operation_level_metrics_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationLevelMetricsConfig is required")]
    [TerraformProperty("operation_level_metrics_config")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OperationLevelMetricsConfig { get; set; }

    /// <summary>
    /// The resolver_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverLevelMetricsBehavior is required")]
    [TerraformProperty("resolver_level_metrics_behavior")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResolverLevelMetricsBehavior { get; set; }

}

/// <summary>
/// Block type for lambda_authorizer_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock() : TerraformBlock("lambda_authorizer_config")
{
    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("authorizer_result_ttl_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    [TerraformProperty("authorizer_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizerUri { get; set; }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    [TerraformProperty("identity_validation_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityValidationExpression { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiLogConfigBlock() : TerraformBlock("log_config")
{
    /// <summary>
    /// The cloudwatch_logs_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogsRoleArn is required")]
    [TerraformProperty("cloudwatch_logs_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudwatchLogsRoleArn { get; set; }

    /// <summary>
    /// The exclude_verbose_content attribute.
    /// </summary>
    [TerraformProperty("exclude_verbose_content")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeVerboseContent { get; set; }

    /// <summary>
    /// The field_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldLogLevel is required")]
    [TerraformProperty("field_log_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FieldLogLevel { get; set; }

}

/// <summary>
/// Block type for openid_connect_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiOpenidConnectConfigBlock() : TerraformBlock("openid_connect_config")
{
    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    [TerraformProperty("auth_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AuthTtl { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    [TerraformProperty("iat_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IatTtl { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformProperty("issuer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Issuer { get; set; }

}

/// <summary>
/// Block type for user_pool_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncGraphqlApiUserPoolConfigBlock() : TerraformBlock("user_pool_config")
{
    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    [TerraformProperty("app_id_client_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppIdClientRegex { get; set; }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformProperty("aws_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsRegion { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformProperty("default_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultAction { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

}

/// <summary>
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppsyncGraphqlApi : TerraformResource
{
    public AwsAppsyncGraphqlApi(string name) : base("aws_appsync_graphql_api", name)
    {
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [TerraformProperty("api_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiType { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The introspection_config attribute.
    /// </summary>
    [TerraformProperty("introspection_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IntrospectionConfig { get; set; }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("merged_api_execution_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MergedApiExecutionRoleArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_depth_limit attribute.
    /// </summary>
    [TerraformProperty("query_depth_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueryDepthLimit { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resolver_count_limit attribute.
    /// </summary>
    [TerraformProperty("resolver_count_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ResolverCountLimit { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Schema { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Visibility { get; set; }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    [TerraformProperty("xray_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? XrayEnabled { get; set; }

    /// <summary>
    /// Block for additional_authentication_provider.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("additional_authentication_provider")]
    public TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock> AdditionalAuthenticationProvider { get; set; } = new();

    /// <summary>
    /// Block for enhanced_metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedMetricsConfig block(s) allowed")]
    [TerraformProperty("enhanced_metrics_config")]
    public TerraformList<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock> EnhancedMetricsConfig { get; set; } = new();

    /// <summary>
    /// Block for lambda_authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    [TerraformProperty("lambda_authorizer_config")]
    public TerraformList<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock> LambdaAuthorizerConfig { get; set; } = new();

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformProperty("log_config")]
    public TerraformList<AwsAppsyncGraphqlApiLogConfigBlock> LogConfig { get; set; } = new();

    /// <summary>
    /// Block for openid_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    [TerraformProperty("openid_connect_config")]
    public TerraformList<AwsAppsyncGraphqlApiOpenidConnectConfigBlock> OpenidConnectConfig { get; set; } = new();

    /// <summary>
    /// Block for user_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    [TerraformProperty("user_pool_config")]
    public TerraformList<AwsAppsyncGraphqlApiUserPoolConfigBlock> UserPoolConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uris attribute.
    /// </summary>
    [TerraformProperty("uris")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Uris { get; }

}
