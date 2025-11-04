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
        this.DeclareOutput("arn");
        this.DeclareOutput("comment");
        this.DeclareOutput("cookies_config");
        this.DeclareOutput("etag");
        this.DeclareOutput("headers_config");
        this.DeclareOutput("query_strings_config");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
