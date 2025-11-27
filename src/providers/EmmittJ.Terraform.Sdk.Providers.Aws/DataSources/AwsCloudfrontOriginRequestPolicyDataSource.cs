using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_request_policy Terraform data source.
/// Retrieves information about a aws_cloudfront_origin_request_policy.
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicyDataSource(string name) : TerraformDataSource("aws_cloudfront_origin_request_policy", name)
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
    /// The cookies_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CookiesConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cookies_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HeadersConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "headers_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QueryStringsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "query_strings_config").ResolveNodes(ctx));
    }

}
