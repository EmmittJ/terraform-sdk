using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for settings in AwsApiGatewayMethodSettings.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayMethodSettingsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// The cache_data_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? CacheDataEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("cache_data_encrypted");
        set => SetArgument("cache_data_encrypted", value);
    }

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? CacheTtlInSeconds
    {
        get => GetArgument<TerraformValue<double>>("cache_ttl_in_seconds");
        set => SetArgument("cache_ttl_in_seconds", value);
    }

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CachingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("caching_enabled");
        set => SetArgument("caching_enabled", value);
    }

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataTraceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_trace_enabled");
        set => SetArgument("data_trace_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformValue<string>? LoggingLevel
    {
        get => GetArgument<TerraformValue<string>>("logging_level");
        set => SetArgument("logging_level", value);
    }

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("metrics_enabled");
        set => SetArgument("metrics_enabled", value);
    }

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    public TerraformValue<bool>? RequireAuthorizationForCacheControl
    {
        get => GetArgument<TerraformValue<bool>>("require_authorization_for_cache_control");
        set => SetArgument("require_authorization_for_cache_control", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingBurstLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_burst_limit");
        set => SetArgument("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingRateLimit
    {
        get => GetArgument<TerraformValue<double>>("throttling_rate_limit");
        set => SetArgument("throttling_rate_limit", value);
    }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    public TerraformValue<string>? UnauthorizedCacheControlHeaderStrategy
    {
        get => GetArgument<TerraformValue<string>>("unauthorized_cache_control_header_strategy");
        set => SetArgument("unauthorized_cache_control_header_strategy", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_method_settings Terraform resource.
/// Manages a aws_api_gateway_method_settings resource.
/// </summary>
public partial class AwsApiGatewayMethodSettings(string name) : TerraformResource("aws_api_gateway_method_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    public required TerraformValue<string> MethodPath
    {
        get => GetArgument<TerraformValue<string>>("method_path");
        set => SetArgument("method_path", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformValue<string> StageName
    {
        get => GetArgument<TerraformValue<string>>("stage_name");
        set => SetArgument("stage_name", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public required TerraformList<AwsApiGatewayMethodSettingsSettingsBlock> Settings
    {
        get => GetRequiredArgument<TerraformList<AwsApiGatewayMethodSettingsSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}
