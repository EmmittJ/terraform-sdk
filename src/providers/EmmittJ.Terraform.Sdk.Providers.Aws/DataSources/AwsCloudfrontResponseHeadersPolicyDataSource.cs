using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_response_headers_policy Terraform data source.
/// Retrieves information about a aws_cloudfront_response_headers_policy.
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyDataSource(string name) : TerraformDataSource("aws_cloudfront_response_headers_policy", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
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
    /// The cors_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomHeadersConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_headers_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoveHeadersConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "remove_headers_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityHeadersConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "security_headers_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerTimingHeadersConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "server_timing_headers_config").ResolveNodes(ctx));
    }

}
