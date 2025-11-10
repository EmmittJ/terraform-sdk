using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_request_policy.
/// </summary>
public class AwsCloudfrontOriginRequestPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginRequestPolicyDataSource(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("comment");
        this.WithOutput("cookies_config");
        this.WithOutput("etag");
        this.WithOutput("headers_config");
        this.WithOutput("query_strings_config");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformExpression Comment => this["comment"];

    /// <summary>
    /// The cookies_config attribute.
    /// </summary>
    public TerraformExpression CookiesConfig => this["cookies_config"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    public TerraformExpression HeadersConfig => this["headers_config"];

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    public TerraformExpression QueryStringsConfig => this["query_strings_config"];

}
