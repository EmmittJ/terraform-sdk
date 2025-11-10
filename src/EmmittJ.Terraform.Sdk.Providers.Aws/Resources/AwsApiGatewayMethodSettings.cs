using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayMethodSettingsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The cache_data_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? CacheDataEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("cache_data_encrypted");
        set => WithProperty("cache_data_encrypted", value);
    }

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? CacheTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("cache_ttl_in_seconds");
        set => WithProperty("cache_ttl_in_seconds", value);
    }

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CachingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("caching_enabled");
        set => WithProperty("caching_enabled", value);
    }

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTraceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_trace_enabled");
        set => WithProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        get => GetProperty<TerraformProperty<string>>("logging_level");
        set => WithProperty("logging_level", value);
    }

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("metrics_enabled");
        set => WithProperty("metrics_enabled", value);
    }

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireAuthorizationForCacheControl
    {
        get => GetProperty<TerraformProperty<bool>>("require_authorization_for_cache_control");
        set => WithProperty("require_authorization_for_cache_control", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_burst_limit");
        set => WithProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        get => GetProperty<TerraformProperty<double>>("throttling_rate_limit");
        set => WithProperty("throttling_rate_limit", value);
    }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? UnauthorizedCacheControlHeaderStrategy
    {
        get => GetProperty<TerraformProperty<string>>("unauthorized_cache_control_header_strategy");
        set => WithProperty("unauthorized_cache_control_header_strategy", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_method_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayMethodSettings : TerraformResource
{
    public AwsApiGatewayMethodSettings(string name) : base("aws_api_gateway_method_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    public required TerraformProperty<string> MethodPath
    {
        get => GetProperty<TerraformProperty<string>>("method_path");
        set => this.WithProperty("method_path", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformProperty<string> StageName
    {
        get => GetProperty<TerraformProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<AwsApiGatewayMethodSettingsSettingsBlock>? Settings
    {
        get => GetProperty<List<AwsApiGatewayMethodSettingsSettingsBlock>>("settings");
        set => this.WithProperty("settings", value);
    }

}
