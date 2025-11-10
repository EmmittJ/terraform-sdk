using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The access_control_allow_credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowCredentials is required")]
    public required TerraformProperty<bool> AccessControlAllowCredentials
    {
        set => SetProperty("access_control_allow_credentials", value);
    }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    public TerraformProperty<double>? AccessControlMaxAgeSec
    {
        set => SetProperty("access_control_max_age_sec", value);
    }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    public required TerraformProperty<bool> OriginOverride
    {
        set => SetProperty("origin_override", value);
    }

}

/// <summary>
/// Block type for custom_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for remove_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for security_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for server_timing_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformProperty<double> SamplingRate
    {
        set => SetProperty("sampling_rate", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_response_headers_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontResponseHeadersPolicy : TerraformResource
{
    public AwsCloudfrontResponseHeadersPolicy(string name) : base("aws_cloudfront_response_headers_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("comment");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for cors_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>? CorsConfig
    {
        set => SetProperty("cors_config", value);
    }

    /// <summary>
    /// Block for custom_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>? CustomHeadersConfig
    {
        set => SetProperty("custom_headers_config", value);
    }

    /// <summary>
    /// Block for remove_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>? RemoveHeadersConfig
    {
        set => SetProperty("remove_headers_config", value);
    }

    /// <summary>
    /// Block for security_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>? SecurityHeadersConfig
    {
        set => SetProperty("security_headers_config", value);
    }

    /// <summary>
    /// Block for server_timing_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>? ServerTimingHeadersConfig
    {
        set => SetProperty("server_timing_headers_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
