using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_authentication_provider in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformPropertyName("authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; }

}

/// <summary>
/// Block type for enhanced_metrics_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The data_source_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceLevelMetricsBehavior is required")]
    [TerraformPropertyName("data_source_level_metrics_behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>
    /// The operation_level_metrics_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationLevelMetricsConfig is required")]
    [TerraformPropertyName("operation_level_metrics_config")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OperationLevelMetricsConfig { get; set; }

    /// <summary>
    /// The resolver_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverLevelMetricsBehavior is required")]
    [TerraformPropertyName("resolver_level_metrics_behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResolverLevelMetricsBehavior { get; set; }

}

/// <summary>
/// Block type for lambda_authorizer_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_result_ttl_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    [TerraformPropertyName("authorizer_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizerUri { get; set; }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    [TerraformPropertyName("identity_validation_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityValidationExpression { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLogConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cloudwatch_logs_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogsRoleArn is required")]
    [TerraformPropertyName("cloudwatch_logs_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudwatchLogsRoleArn { get; set; }

    /// <summary>
    /// The exclude_verbose_content attribute.
    /// </summary>
    [TerraformPropertyName("exclude_verbose_content")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExcludeVerboseContent { get; set; }

    /// <summary>
    /// The field_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldLogLevel is required")]
    [TerraformPropertyName("field_log_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FieldLogLevel { get; set; }

}

/// <summary>
/// Block type for openid_connect_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiOpenidConnectConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    [TerraformPropertyName("auth_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AuthTtl { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    [TerraformPropertyName("iat_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IatTtl { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformPropertyName("issuer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Issuer { get; set; }

}

/// <summary>
/// Block type for user_pool_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiUserPoolConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    [TerraformPropertyName("app_id_client_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppIdClientRegex { get; set; }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformPropertyName("aws_region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsRegion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "aws_region");

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformPropertyName("default_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultAction { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

}

/// <summary>
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncGraphqlApi : TerraformResource
{
    public AwsAppsyncGraphqlApi(string name) : base("aws_appsync_graphql_api", name)
    {
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [TerraformPropertyName("api_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiType { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformPropertyName("authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The introspection_config attribute.
    /// </summary>
    [TerraformPropertyName("introspection_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IntrospectionConfig { get; set; }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("merged_api_execution_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MergedApiExecutionRoleArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The query_depth_limit attribute.
    /// </summary>
    [TerraformPropertyName("query_depth_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueryDepthLimit { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resolver_count_limit attribute.
    /// </summary>
    [TerraformPropertyName("resolver_count_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ResolverCountLimit { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schema { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Visibility { get; set; }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    [TerraformPropertyName("xray_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? XrayEnabled { get; set; }

    /// <summary>
    /// Block for additional_authentication_provider.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("additional_authentication_provider")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>>? AdditionalAuthenticationProvider { get; set; } = new();

    /// <summary>
    /// Block for enhanced_metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedMetricsConfig block(s) allowed")]
    [TerraformPropertyName("enhanced_metrics_config")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>>? EnhancedMetricsConfig { get; set; } = new();

    /// <summary>
    /// Block for lambda_authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    [TerraformPropertyName("lambda_authorizer_config")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>>? LambdaAuthorizerConfig { get; set; } = new();

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiLogConfigBlock>>? LogConfig { get; set; } = new();

    /// <summary>
    /// Block for openid_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    [TerraformPropertyName("openid_connect_config")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>>? OpenidConnectConfig { get; set; } = new();

    /// <summary>
    /// Block for user_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    [TerraformPropertyName("user_pool_config")]
    public TerraformList<TerraformBlock<AwsAppsyncGraphqlApiUserPoolConfigBlock>>? UserPoolConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The uris attribute.
    /// </summary>
    [TerraformPropertyName("uris")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Uris => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "uris");

}
