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
        get => GetProperty<TerraformProperty<bool>>("access_control_allow_credentials");
        set => WithProperty("access_control_allow_credentials", value);
    }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    public TerraformProperty<double>? AccessControlMaxAgeSec
    {
        get => GetProperty<TerraformProperty<double>>("access_control_max_age_sec");
        set => WithProperty("access_control_max_age_sec", value);
    }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    public required TerraformProperty<bool> OriginOverride
    {
        get => GetProperty<TerraformProperty<bool>>("origin_override");
        set => WithProperty("origin_override", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformProperty<double> SamplingRate
    {
        get => GetProperty<TerraformProperty<double>>("sampling_rate");
        set => WithProperty("sampling_rate", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for cors_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>? CorsConfig
    {
        get => GetProperty<List<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>>("cors_config");
        set => this.WithProperty("cors_config", value);
    }

    /// <summary>
    /// Block for custom_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>? CustomHeadersConfig
    {
        get => GetProperty<List<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>>("custom_headers_config");
        set => this.WithProperty("custom_headers_config", value);
    }

    /// <summary>
    /// Block for remove_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>? RemoveHeadersConfig
    {
        get => GetProperty<List<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>>("remove_headers_config");
        set => this.WithProperty("remove_headers_config", value);
    }

    /// <summary>
    /// Block for security_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>? SecurityHeadersConfig
    {
        get => GetProperty<List<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>>("security_headers_config");
        set => this.WithProperty("security_headers_config", value);
    }

    /// <summary>
    /// Block for server_timing_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    public List<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>? ServerTimingHeadersConfig
    {
        get => GetProperty<List<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>>("server_timing_headers_config");
        set => this.WithProperty("server_timing_headers_config", value);
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
