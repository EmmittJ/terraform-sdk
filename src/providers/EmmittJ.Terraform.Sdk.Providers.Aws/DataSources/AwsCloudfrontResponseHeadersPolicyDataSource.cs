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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
        => AsReference("comment");

    /// <summary>
    /// The cors_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfig
        => AsReference("cors_config");

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomHeadersConfig
        => AsReference("custom_headers_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoveHeadersConfig
        => AsReference("remove_headers_config");

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityHeadersConfig
        => AsReference("security_headers_config");

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServerTimingHeadersConfig
        => AsReference("server_timing_headers_config");

}
