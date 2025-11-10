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
        set => SetProperty("cache_data_encrypted", value);
    }

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? CacheTtlInSeconds
    {
        set => SetProperty("cache_ttl_in_seconds", value);
    }

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CachingEnabled
    {
        set => SetProperty("caching_enabled", value);
    }

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTraceEnabled
    {
        set => SetProperty("data_trace_enabled", value);
    }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingLevel
    {
        set => SetProperty("logging_level", value);
    }

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MetricsEnabled
    {
        set => SetProperty("metrics_enabled", value);
    }

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireAuthorizationForCacheControl
    {
        set => SetProperty("require_authorization_for_cache_control", value);
    }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingBurstLimit
    {
        set => SetProperty("throttling_burst_limit", value);
    }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ThrottlingRateLimit
    {
        set => SetProperty("throttling_rate_limit", value);
    }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? UnauthorizedCacheControlHeaderStrategy
    {
        set => SetProperty("unauthorized_cache_control_header_strategy", value);
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
        SetOutput("id");
        SetOutput("method_path");
        SetOutput("region");
        SetOutput("rest_api_id");
        SetOutput("stage_name");
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
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    public required TerraformProperty<string> MethodPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("method_path");
        set => SetProperty("method_path", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    public required TerraformProperty<string> StageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage_name");
        set => SetProperty("stage_name", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<AwsApiGatewayMethodSettingsSettingsBlock>? Settings
    {
        set => SetProperty("settings", value);
    }

}
