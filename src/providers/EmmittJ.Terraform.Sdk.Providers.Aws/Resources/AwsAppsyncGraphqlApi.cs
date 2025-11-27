using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_authentication_provider in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_authentication_provider";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// LambdaAuthorizerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockLambdaAuthorizerConfigBlock>? LambdaAuthorizerConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockLambdaAuthorizerConfigBlock>>("lambda_authorizer_config");
        set => SetArgument("lambda_authorizer_config", value);
    }

    /// <summary>
    /// OpenidConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockOpenidConnectConfigBlock>? OpenidConnectConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockOpenidConnectConfigBlock>>("openid_connect_config");
        set => SetArgument("openid_connect_config", value);
    }

    /// <summary>
    /// UserPoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockUserPoolConfigBlock>? UserPoolConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockUserPoolConfigBlock>>("user_pool_config");
        set => SetArgument("user_pool_config", value);
    }

}

/// <summary>
/// Block type for lambda_authorizer_config in AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockLambdaAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_authorizer_config";

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AuthorizerResultTtlInSeconds
    {
        get => new TerraformReference<double>(this, "authorizer_result_ttl_in_seconds");
        set => SetArgument("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    public required TerraformValue<string> AuthorizerUri
    {
        get => new TerraformReference<string>(this, "authorizer_uri");
        set => SetArgument("authorizer_uri", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string>? IdentityValidationExpression
    {
        get => new TerraformReference<string>(this, "identity_validation_expression");
        set => SetArgument("identity_validation_expression", value);
    }

}

/// <summary>
/// Block type for openid_connect_config in AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockOpenidConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "openid_connect_config";

    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    public TerraformValue<double>? AuthTtl
    {
        get => new TerraformReference<double>(this, "auth_ttl");
        set => SetArgument("auth_ttl", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    public TerraformValue<double>? IatTtl
    {
        get => new TerraformReference<double>(this, "iat_ttl");
        set => SetArgument("iat_ttl", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

}

/// <summary>
/// Block type for user_pool_config in AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlockUserPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_pool_config";

    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    public TerraformValue<string>? AppIdClientRegex
    {
        get => new TerraformReference<string>(this, "app_id_client_regex");
        set => SetArgument("app_id_client_regex", value);
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string> AwsRegion
    {
        get => new TerraformReference<string>(this, "aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}


/// <summary>
/// Block type for enhanced_metrics_config in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enhanced_metrics_config";

    /// <summary>
    /// The data_source_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceLevelMetricsBehavior is required")]
    public required TerraformValue<string> DataSourceLevelMetricsBehavior
    {
        get => new TerraformReference<string>(this, "data_source_level_metrics_behavior");
        set => SetArgument("data_source_level_metrics_behavior", value);
    }

    /// <summary>
    /// The operation_level_metrics_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationLevelMetricsConfig is required")]
    public required TerraformValue<string> OperationLevelMetricsConfig
    {
        get => new TerraformReference<string>(this, "operation_level_metrics_config");
        set => SetArgument("operation_level_metrics_config", value);
    }

    /// <summary>
    /// The resolver_level_metrics_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverLevelMetricsBehavior is required")]
    public required TerraformValue<string> ResolverLevelMetricsBehavior
    {
        get => new TerraformReference<string>(this, "resolver_level_metrics_behavior");
        set => SetArgument("resolver_level_metrics_behavior", value);
    }

}


/// <summary>
/// Block type for lambda_authorizer_config in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_authorizer_config";

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AuthorizerResultTtlInSeconds
    {
        get => new TerraformReference<double>(this, "authorizer_result_ttl_in_seconds");
        set => SetArgument("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    public required TerraformValue<string> AuthorizerUri
    {
        get => new TerraformReference<string>(this, "authorizer_uri");
        set => SetArgument("authorizer_uri", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string>? IdentityValidationExpression
    {
        get => new TerraformReference<string>(this, "identity_validation_expression");
        set => SetArgument("identity_validation_expression", value);
    }

}


/// <summary>
/// Block type for log_config in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// The cloudwatch_logs_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogsRoleArn is required")]
    public required TerraformValue<string> CloudwatchLogsRoleArn
    {
        get => new TerraformReference<string>(this, "cloudwatch_logs_role_arn");
        set => SetArgument("cloudwatch_logs_role_arn", value);
    }

    /// <summary>
    /// The exclude_verbose_content attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeVerboseContent
    {
        get => new TerraformReference<bool>(this, "exclude_verbose_content");
        set => SetArgument("exclude_verbose_content", value);
    }

    /// <summary>
    /// The field_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldLogLevel is required")]
    public required TerraformValue<string> FieldLogLevel
    {
        get => new TerraformReference<string>(this, "field_log_level");
        set => SetArgument("field_log_level", value);
    }

}


/// <summary>
/// Block type for openid_connect_config in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiOpenidConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "openid_connect_config";

    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    public TerraformValue<double>? AuthTtl
    {
        get => new TerraformReference<double>(this, "auth_ttl");
        set => SetArgument("auth_ttl", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    public TerraformValue<double>? IatTtl
    {
        get => new TerraformReference<double>(this, "iat_ttl");
        set => SetArgument("iat_ttl", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

}


/// <summary>
/// Block type for user_pool_config in AwsAppsyncGraphqlApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncGraphqlApiUserPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_pool_config";

    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    public TerraformValue<string>? AppIdClientRegex
    {
        get => new TerraformReference<string>(this, "app_id_client_regex");
        set => SetArgument("app_id_client_regex", value);
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string> AwsRegion
    {
        get => new TerraformReference<string>(this, "aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}


/// <summary>
/// Represents a aws_appsync_graphql_api Terraform resource.
/// Manages a aws_appsync_graphql_api resource.
/// </summary>
public partial class AwsAppsyncGraphqlApi(string name) : TerraformResource("aws_appsync_graphql_api", name)
{
    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformValue<string>? ApiType
    {
        get => new TerraformReference<string>(this, "api_type");
        set => SetArgument("api_type", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The introspection_config attribute.
    /// </summary>
    public TerraformValue<string>? IntrospectionConfig
    {
        get => new TerraformReference<string>(this, "introspection_config");
        set => SetArgument("introspection_config", value);
    }

    /// <summary>
    /// The merged_api_execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? MergedApiExecutionRoleArn
    {
        get => new TerraformReference<string>(this, "merged_api_execution_role_arn");
        set => SetArgument("merged_api_execution_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_depth_limit attribute.
    /// </summary>
    public TerraformValue<double>? QueryDepthLimit
    {
        get => new TerraformReference<double>(this, "query_depth_limit");
        set => SetArgument("query_depth_limit", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_count_limit attribute.
    /// </summary>
    public TerraformValue<double>? ResolverCountLimit
    {
        get => new TerraformReference<double>(this, "resolver_count_limit");
        set => SetArgument("resolver_count_limit", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string>? Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string>? Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? XrayEnabled
    {
        get => new TerraformReference<bool>(this, "xray_enabled");
        set => SetArgument("xray_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The uris attribute.
    /// </summary>
    public TerraformMap<string> Uris
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "uris").ResolveNodes(ctx));
    }

    /// <summary>
    /// AdditionalAuthenticationProvider block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>? AdditionalAuthenticationProvider
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiAdditionalAuthenticationProviderBlock>>("additional_authentication_provider");
        set => SetArgument("additional_authentication_provider", value);
    }

    /// <summary>
    /// EnhancedMetricsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedMetricsConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>? EnhancedMetricsConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiEnhancedMetricsConfigBlock>>("enhanced_metrics_config");
        set => SetArgument("enhanced_metrics_config", value);
    }

    /// <summary>
    /// LambdaAuthorizerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaAuthorizerConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>? LambdaAuthorizerConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiLambdaAuthorizerConfigBlock>>("lambda_authorizer_config");
        set => SetArgument("lambda_authorizer_config", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// OpenidConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidConnectConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>? OpenidConnectConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiOpenidConnectConfigBlock>>("openid_connect_config");
        set => SetArgument("openid_connect_config", value);
    }

    /// <summary>
    /// UserPoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolConfig block(s) allowed")]
    public TerraformList<AwsAppsyncGraphqlApiUserPoolConfigBlock>? UserPoolConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncGraphqlApiUserPoolConfigBlock>>("user_pool_config");
        set => SetArgument("user_pool_config", value);
    }

}
