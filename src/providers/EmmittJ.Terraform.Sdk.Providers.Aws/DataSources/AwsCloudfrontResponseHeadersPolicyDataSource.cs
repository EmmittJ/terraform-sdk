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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
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
    /// The cors_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfig
        => CreateReference("cors_config");

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomHeadersConfig
        => CreateReference("custom_headers_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoveHeadersConfig
        => CreateReference("remove_headers_config");

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityHeadersConfig
        => CreateReference("security_headers_config");

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerTimingHeadersConfig
        => CreateReference("server_timing_headers_config");

}
