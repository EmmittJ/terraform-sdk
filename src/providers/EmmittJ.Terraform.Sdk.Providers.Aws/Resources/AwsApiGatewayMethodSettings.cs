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
    public TerraformValue<bool> CacheDataEncrypted
    {
        get => new TerraformReference<bool>(this, "cache_data_encrypted");
        set => SetArgument("cache_data_encrypted", value);
    }

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> CacheTtlInSeconds
    {
        get => new TerraformReference<double>(this, "cache_ttl_in_seconds");
        set => SetArgument("cache_ttl_in_seconds", value);
    }

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CachingEnabled
    {
        get => new TerraformReference<bool>(this, "caching_enabled");
        set => SetArgument("caching_enabled", value);
    }

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataTraceEnabled
    {
        get => new TerraformReference<bool>(this, "data_trace_enabled");
        set => SetArgument("data_trace_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformValue<string> LoggingLevel
    {
        get => new TerraformReference<string>(this, "logging_level");
        set => SetArgument("logging_level", value);
    }

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MetricsEnabled
    {
        get => new TerraformReference<bool>(this, "metrics_enabled");
        set => SetArgument("metrics_enabled", value);
    }

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    public TerraformValue<bool> RequireAuthorizationForCacheControl
    {
        get => new TerraformReference<bool>(this, "require_authorization_for_cache_control");
        set => SetArgument("require_authorization_for_cache_control", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingBurstLimit
    {
        get => new TerraformReference<double>(this, "throttling_burst_limit");
        set => SetArgument("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? ThrottlingRateLimit
    {
        get => new TerraformReference<double>(this, "throttling_rate_limit");
        set => SetArgument("throttling_rate_limit", value);
    }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    public TerraformValue<string> UnauthorizedCacheControlHeaderStrategy
    {
        get => new TerraformReference<string>(this, "unauthorized_cache_control_header_strategy");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    public required TerraformValue<string> MethodPath
    {
        get => new TerraformReference<string>(this, "method_path");
        set => SetArgument("method_path", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformValue<string> StageName
    {
        get => new TerraformReference<string>(this, "stage_name");
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
