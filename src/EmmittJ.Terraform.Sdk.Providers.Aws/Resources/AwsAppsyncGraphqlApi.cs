using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_authentication_provider in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => WithProperty("authentication_type", value);
    }

}

/// <summary>
/// Block type for enhanced_metrics_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The data_source_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceLevelMetricsBehavior is required")]
    public required TerraformProperty<string> DataSourceLevelMetricsBehavior
    {
        get => GetProperty<TerraformProperty<string>>("data_source_level_metrics_behavior");
        set => WithProperty("data_source_level_metrics_behavior", value);
    }

    /// <summary>
    /// The operation_level_metrics_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationLevelMetricsConfig is required")]
    public required TerraformProperty<string> OperationLevelMetricsConfig
    {
        get => GetProperty<TerraformProperty<string>>("operation_level_metrics_config");
        set => WithProperty("operation_level_metrics_config", value);
    }

    /// <summary>
    /// The resolver_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverLevelMetricsBehavior is required")]
    public required TerraformProperty<string> ResolverLevelMetricsBehavior
    {
        get => GetProperty<TerraformProperty<string>>("resolver_level_metrics_behavior");
        set => WithProperty("resolver_level_metrics_behavior", value);
    }

}

/// <summary>
/// Block type for lambda_authorizer_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? AuthorizerResultTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("authorizer_result_ttl_in_seconds");
        set => WithProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    public required TerraformProperty<string> AuthorizerUri
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_uri");
        set => WithProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityValidationExpression
    {
        get => GetProperty<TerraformProperty<string>>("identity_validation_expression");
        set => WithProperty("identity_validation_expression", value);
    }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_logs_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogsRoleArn is required")]
    public required TerraformProperty<string> CloudwatchLogsRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_logs_role_arn");
        set => WithProperty("cloudwatch_logs_role_arn", value);
    }

    /// <summary>
    /// The exclude_verbose_content attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeVerboseContent
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_verbose_content");
        set => WithProperty("exclude_verbose_content", value);
    }

    /// <summary>
    /// The field_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldLogLevel is required")]
    public required TerraformProperty<string> FieldLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("field_log_level");
        set => WithProperty("field_log_level", value);
    }

}

/// <summary>
/// Block type for openid_connect_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiOpenidConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? AuthTtl
    {
        get => GetProperty<TerraformProperty<double>>("auth_ttl");
        set => WithProperty("auth_ttl", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? IatTtl
    {
        get => GetProperty<TerraformProperty<double>>("iat_ttl");
        set => WithProperty("iat_ttl", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

}

/// <summary>
/// Block type for user_pool_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiUserPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    public TerraformProperty<string>? AppIdClientRegex
    {
        get => GetProperty<TerraformProperty<string>>("app_id_client_regex");
        set => WithProperty("app_id_client_regex", value);
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string>? AwsRegion
    {
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => WithProperty("aws_region", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => WithProperty("default_action", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => WithProperty("user_pool_id", value);
    }

}

/// <summary>
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
public class AwsAppsyncGraphqlApi : TerraformResource
{
    public AwsAppsyncGraphqlApi(string name) : base("aws_appsync_graphql_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uris");
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformProperty<string>? ApiType
    {
        get => GetProperty<TerraformProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
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
    /// The introspection_config attribute.
    /// </summary>
    public TerraformProperty<string>? IntrospectionConfig
    {
        get => GetProperty<TerraformProperty<string>>("introspection_config");
        set => this.WithProperty("introspection_config", value);
    }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? MergedApiExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("merged_api_execution_role_arn");
        set => this.WithProperty("merged_api_execution_role_arn", value);
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
    /// The query_depth_limit attribute.
    /// </summary>
    public TerraformProperty<double>? QueryDepthLimit
    {
        get => GetProperty<TerraformProperty<double>>("query_depth_limit");
        set => this.WithProperty("query_depth_limit", value);
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
    /// The resolver_count_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ResolverCountLimit
    {
        get => GetProperty<TerraformProperty<double>>("resolver_count_limit");
        set => this.WithProperty("resolver_count_limit", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string>? Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => this.WithProperty("visibility", value);
    }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? XrayEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("xray_enabled");
        set => this.WithProperty("xray_enabled", value);
    }

    /// <summary>
    /// Block for additional_authentication_provider.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>? AdditionalAuthenticationProvider
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>>("additional_authentication_provider");
        set => this.WithProperty("additional_authentication_provider", value);
    }

    /// <summary>
    /// Block for enhanced_metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedMetricsConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>? EnhancedMetricsConfig
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>>("enhanced_metrics_config");
        set => this.WithProperty("enhanced_metrics_config", value);
    }

    /// <summary>
    /// Block for lambda_authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>? LambdaAuthorizerConfig
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>>("lambda_authorizer_config");
        set => this.WithProperty("lambda_authorizer_config", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiLogConfigBlock>? LogConfig
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiLogConfigBlock>>("log_config");
        set => this.WithProperty("log_config", value);
    }

    /// <summary>
    /// Block for openid_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>? OpenidConnectConfig
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>>("openid_connect_config");
        set => this.WithProperty("openid_connect_config", value);
    }

    /// <summary>
    /// Block for user_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiUserPoolConfigBlock>? UserPoolConfig
    {
        get => GetProperty<List<AwsAppsyncGraphqlApiUserPoolConfigBlock>>("user_pool_config");
        set => this.WithProperty("user_pool_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uris attribute.
    /// </summary>
    public TerraformExpression Uris => this["uris"];

}
