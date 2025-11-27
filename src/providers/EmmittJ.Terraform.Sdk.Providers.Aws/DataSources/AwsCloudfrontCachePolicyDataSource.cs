using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_cache_policy Terraform data source.
/// Retrieves information about a aws_cloudfront_cache_policy.
/// </summary>
public partial class AwsCloudfrontCachePolicyDataSource(string name) : TerraformDataSource("aws_cloudfront_cache_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
    {
        get => new TerraformReference<string>(this, "comment");
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double> DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double> MaxTtl
    {
        get => new TerraformReference<double>(this, "max_ttl");
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double> MinTtl
    {
        get => new TerraformReference<double>(this, "min_ttl");
    }

    /// <summary>
    /// The parameters_in_cache_key_and_forwarded_to_origin attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ParametersInCacheKeyAndForwardedToOrigin
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "parameters_in_cache_key_and_forwarded_to_origin").ResolveNodes(ctx));
    }

}
