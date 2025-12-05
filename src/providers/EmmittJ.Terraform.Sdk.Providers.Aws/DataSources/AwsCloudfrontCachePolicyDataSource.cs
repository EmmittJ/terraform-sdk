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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
        => CreateReference("comment");

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double> DefaultTtl
        => CreateReference("default_ttl");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double> MaxTtl
        => CreateReference("max_ttl");

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double> MinTtl
        => CreateReference("min_ttl");

    /// <summary>
    /// The parameters_in_cache_key_and_forwarded_to_origin attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ParametersInCacheKeyAndForwardedToOrigin
        => CreateReference("parameters_in_cache_key_and_forwarded_to_origin");

}
