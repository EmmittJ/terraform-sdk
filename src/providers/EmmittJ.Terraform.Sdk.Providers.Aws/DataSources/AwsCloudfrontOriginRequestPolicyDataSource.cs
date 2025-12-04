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
        => AsReference("arn");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
        => AsReference("comment");

    /// <summary>
    /// The cookies_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CookiesConfig
        => AsReference("cookies_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HeadersConfig
        => AsReference("headers_config");

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QueryStringsConfig
        => AsReference("query_strings_config");

}
