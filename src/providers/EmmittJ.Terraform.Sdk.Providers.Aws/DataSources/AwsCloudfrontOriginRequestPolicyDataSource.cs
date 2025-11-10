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
        SetOutput("arn");
        SetOutput("comment");
        SetOutput("cookies_config");
        SetOutput("etag");
        SetOutput("headers_config");
        SetOutput("query_strings_config");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
