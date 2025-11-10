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
        get => GetProperty<TerraformProperty<bool>>("enable_accept_encoding_brotli");
        set => WithProperty("enable_accept_encoding_brotli", value);
    }

    /// <summary>
    /// The enable_accept_encoding_gzip attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceptEncodingGzip
    {
        get => GetProperty<TerraformProperty<bool>>("enable_accept_encoding_gzip");
        set => WithProperty("enable_accept_encoding_gzip", value);
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
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => this.WithProperty("default_ttl", value);
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
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        get => GetProperty<TerraformProperty<double>>("max_ttl");
        set => this.WithProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinTtl
    {
        get => GetProperty<TerraformProperty<double>>("min_ttl");
        set => this.WithProperty("min_ttl", value);
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
    /// Block for parameters_in_cache_key_and_forwarded_to_origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ParametersInCacheKeyAndForwardedToOrigin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParametersInCacheKeyAndForwardedToOrigin block(s) allowed")]
    public List<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>? ParametersInCacheKeyAndForwardedToOrigin
    {
        get => GetProperty<List<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>>("parameters_in_cache_key_and_forwarded_to_origin");
        set => this.WithProperty("parameters_in_cache_key_and_forwarded_to_origin", value);
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
