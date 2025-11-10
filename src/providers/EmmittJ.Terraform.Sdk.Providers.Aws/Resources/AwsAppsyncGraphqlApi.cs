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
        set => SetProperty("authentication_type", value);
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
        set => SetProperty("data_source_level_metrics_behavior", value);
    }

    /// <summary>
    /// The operation_level_metrics_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationLevelMetricsConfig is required")]
    public required TerraformProperty<string> OperationLevelMetricsConfig
    {
        set => SetProperty("operation_level_metrics_config", value);
    }

    /// <summary>
    /// The resolver_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverLevelMetricsBehavior is required")]
    public required TerraformProperty<string> ResolverLevelMetricsBehavior
    {
        set => SetProperty("resolver_level_metrics_behavior", value);
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
        set => SetProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    public required TerraformProperty<string> AuthorizerUri
    {
        set => SetProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityValidationExpression
    {
        set => SetProperty("identity_validation_expression", value);
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
        set => SetProperty("cloudwatch_logs_role_arn", value);
    }

    /// <summary>
    /// The exclude_verbose_content attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeVerboseContent
    {
        set => SetProperty("exclude_verbose_content", value);
    }

    /// <summary>
    /// The field_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldLogLevel is required")]
    public required TerraformProperty<string> FieldLogLevel
    {
        set => SetProperty("field_log_level", value);
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
        set => SetProperty("auth_ttl", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? IatTtl
    {
        set => SetProperty("iat_ttl", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        set => SetProperty("issuer", value);
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
        set => SetProperty("app_id_client_regex", value);
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string>? AwsRegion
    {
        set => SetProperty("aws_region", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        set => SetProperty("user_pool_id", value);
    }

}

/// <summary>
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncGraphqlApi : TerraformResource
{
    public AwsAppsyncGraphqlApi(string name) : base("aws_appsync_graphql_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("uris");
        SetOutput("api_type");
        SetOutput("authentication_type");
        SetOutput("id");
        SetOutput("introspection_config");
        SetOutput("merged_api_execution_role_arn");
        SetOutput("name");
        SetOutput("query_depth_limit");
        SetOutput("region");
        SetOutput("resolver_count_limit");
        SetOutput("schema");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("visibility");
        SetOutput("xray_enabled");
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformProperty<string> ApiType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_type");
        set => SetProperty("api_type", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
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
    /// The introspection_config attribute.
    /// </summary>
    public TerraformProperty<string> IntrospectionConfig
    {
        get => GetRequiredOutput<TerraformProperty<string>>("introspection_config");
        set => SetProperty("introspection_config", value);
    }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> MergedApiExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("merged_api_execution_role_arn");
        set => SetProperty("merged_api_execution_role_arn", value);
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
    /// The query_depth_limit attribute.
    /// </summary>
    public TerraformProperty<double> QueryDepthLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("query_depth_limit");
        set => SetProperty("query_depth_limit", value);
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
    /// The resolver_count_limit attribute.
    /// </summary>
    public TerraformProperty<double> ResolverCountLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("resolver_count_limit");
        set => SetProperty("resolver_count_limit", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string> Schema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema");
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string> Visibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("visibility");
        set => SetProperty("visibility", value);
    }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> XrayEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("xray_enabled");
        set => SetProperty("xray_enabled", value);
    }

    /// <summary>
    /// Block for additional_authentication_provider.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>? AdditionalAuthenticationProvider
    {
        set => SetProperty("additional_authentication_provider", value);
    }

    /// <summary>
    /// Block for enhanced_metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedMetricsConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>? EnhancedMetricsConfig
    {
        set => SetProperty("enhanced_metrics_config", value);
    }

    /// <summary>
    /// Block for lambda_authorizer_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>? LambdaAuthorizerConfig
    {
        set => SetProperty("lambda_authorizer_config", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiLogConfigBlock>? LogConfig
    {
        set => SetProperty("log_config", value);
    }

    /// <summary>
    /// Block for openid_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>? OpenidConnectConfig
    {
        set => SetProperty("openid_connect_config", value);
    }

    /// <summary>
    /// Block for user_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    public List<AwsAppsyncGraphqlApiUserPoolConfigBlock>? UserPoolConfig
    {
        set => SetProperty("user_pool_config", value);
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
