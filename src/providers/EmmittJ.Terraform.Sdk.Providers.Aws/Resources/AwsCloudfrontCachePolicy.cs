using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters_in_cache_key_and_forwarded_to_origin in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock : TerraformBlock
{
    /// <summary>
    /// The enable_accept_encoding_brotli attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceptEncodingBrotli
    {
        set => SetProperty("enable_accept_encoding_brotli", value);
    }

    /// <summary>
    /// The enable_accept_encoding_gzip attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceptEncodingGzip
    {
        set => SetProperty("enable_accept_encoding_gzip", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_cache_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontCachePolicy : TerraformResource
{
    public AwsCloudfrontCachePolicy(string name) : base("aws_cloudfront_cache_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("comment");
        SetOutput("default_ttl");
        SetOutput("id");
        SetOutput("max_ttl");
        SetOutput("min_ttl");
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
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double> DefaultTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_ttl");
        set => SetProperty("default_ttl", value);
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
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double> MaxTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_ttl");
        set => SetProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double> MinTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_ttl");
        set => SetProperty("min_ttl", value);
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
    /// Block for parameters_in_cache_key_and_forwarded_to_origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParametersInCacheKeyAndForwardedToOrigin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ParametersInCacheKeyAndForwardedToOrigin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParametersInCacheKeyAndForwardedToOrigin block(s) allowed")]
    public List<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>? ParametersInCacheKeyAndForwardedToOrigin
    {
        set => SetProperty("parameters_in_cache_key_and_forwarded_to_origin", value);
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
