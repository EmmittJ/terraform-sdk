using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_config in AwsAppsyncApi.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_config";

    /// <summary>
    /// AuthProvider block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlock>? AuthProvider
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlock>>("auth_provider");
        set => SetArgument("auth_provider", value);
    }

    /// <summary>
    /// ConnectionAuthMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockConnectionAuthModeBlock>? ConnectionAuthMode
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockConnectionAuthModeBlock>>("connection_auth_mode");
        set => SetArgument("connection_auth_mode", value);
    }

    /// <summary>
    /// DefaultPublishAuthMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockDefaultPublishAuthModeBlock>? DefaultPublishAuthMode
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockDefaultPublishAuthModeBlock>>("default_publish_auth_mode");
        set => SetArgument("default_publish_auth_mode", value);
    }

    /// <summary>
    /// DefaultSubscribeAuthMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockDefaultSubscribeAuthModeBlock>? DefaultSubscribeAuthMode
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockDefaultSubscribeAuthModeBlock>>("default_subscribe_auth_mode");
        set => SetArgument("default_subscribe_auth_mode", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

}

/// <summary>
/// Block type for auth_provider in AwsAppsyncApiEventConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockAuthProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_provider";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// CognitoConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockCognitoConfigBlock>? CognitoConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockCognitoConfigBlock>>("cognito_config");
        set => SetArgument("cognito_config", value);
    }

    /// <summary>
    /// LambdaAuthorizerConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockLambdaAuthorizerConfigBlock>? LambdaAuthorizerConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockLambdaAuthorizerConfigBlock>>("lambda_authorizer_config");
        set => SetArgument("lambda_authorizer_config", value);
    }

    /// <summary>
    /// OpenidConnectConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockOpenidConnectConfigBlock>? OpenidConnectConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlockAuthProviderBlockOpenidConnectConfigBlock>>("openid_connect_config");
        set => SetArgument("openid_connect_config", value);
    }

}

/// <summary>
/// Block type for cognito_config in AwsAppsyncApiEventConfigBlockAuthProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockAuthProviderBlockCognitoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_config";

    /// <summary>
    /// The app_id_client_regex attribute.
    /// </summary>
    public TerraformValue<string>? AppIdClientRegex
    {
        get => GetArgument<TerraformValue<string>>("app_id_client_regex");
        set => SetArgument("app_id_client_regex", value);
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    public required TerraformValue<string> AwsRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}

/// <summary>
/// Block type for lambda_authorizer_config in AwsAppsyncApiEventConfigBlockAuthProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockAuthProviderBlockLambdaAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_authorizer_config";

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> AuthorizerResultTtlInSeconds
    {
        get => GetArgument<TerraformValue<double>>("authorizer_result_ttl_in_seconds") ?? AsReference("authorizer_result_ttl_in_seconds");
        set => SetArgument("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerUri is required")]
    public required TerraformValue<string> AuthorizerUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorizer_uri");
        set => SetArgument("authorizer_uri", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string>? IdentityValidationExpression
    {
        get => GetArgument<TerraformValue<string>>("identity_validation_expression");
        set => SetArgument("identity_validation_expression", value);
    }

}

/// <summary>
/// Block type for openid_connect_config in AwsAppsyncApiEventConfigBlockAuthProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockAuthProviderBlockOpenidConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "openid_connect_config";

    /// <summary>
    /// The auth_ttl attribute.
    /// </summary>
    public TerraformValue<double> AuthTtl
    {
        get => GetArgument<TerraformValue<double>>("auth_ttl") ?? AsReference("auth_ttl");
        set => SetArgument("auth_ttl", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The iat_ttl attribute.
    /// </summary>
    public TerraformValue<double> IatTtl
    {
        get => GetArgument<TerraformValue<double>>("iat_ttl") ?? AsReference("iat_ttl");
        set => SetArgument("iat_ttl", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

}

/// <summary>
/// Block type for connection_auth_mode in AwsAppsyncApiEventConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockConnectionAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_auth_mode";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

}

/// <summary>
/// Block type for default_publish_auth_mode in AwsAppsyncApiEventConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockDefaultPublishAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_publish_auth_mode";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

}

/// <summary>
/// Block type for default_subscribe_auth_mode in AwsAppsyncApiEventConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockDefaultSubscribeAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_subscribe_auth_mode";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

}

/// <summary>
/// Block type for log_config in AwsAppsyncApiEventConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlockLogConfigBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("cloudwatch_logs_role_arn");
        set => SetArgument("cloudwatch_logs_role_arn", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogLevel is required")]
    public required TerraformValue<string> LogLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_level");
        set => SetArgument("log_level", value);
    }

}


/// <summary>
/// Represents a aws_appsync_api Terraform resource.
/// Manages a aws_appsync_api resource.
/// </summary>
public partial class AwsAppsyncApi(string name) : TerraformResource("aws_appsync_api", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    public TerraformValue<string>? OwnerContact
    {
        get => GetArgument<TerraformValue<string>>("owner_contact");
        set => SetArgument("owner_contact", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_arn attribute.
    /// </summary>
    public TerraformValue<string> ApiArn
        => AsReference("api_arn");

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformValue<string> ApiId
        => AsReference("api_id");

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformMap<string> Dns
        => AsReference("dns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The waf_web_acl_arn attribute.
    /// </summary>
    public TerraformValue<string> WafWebAclArn
        => AsReference("waf_web_acl_arn");

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformValue<bool> XrayEnabled
        => AsReference("xray_enabled");

    /// <summary>
    /// EventConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncApiEventConfigBlock>? EventConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncApiEventConfigBlock>>("event_config");
        set => SetArgument("event_config", value);
    }

}
