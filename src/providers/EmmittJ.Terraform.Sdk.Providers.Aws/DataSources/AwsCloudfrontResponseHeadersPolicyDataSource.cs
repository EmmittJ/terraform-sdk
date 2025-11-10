using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_response_headers_policy.
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontResponseHeadersPolicyDataSource(string name) : base("aws_cloudfront_response_headers_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("comment");
        SetOutput("cors_config");
        SetOutput("custom_headers_config");
        SetOutput("etag");
        SetOutput("remove_headers_config");
        SetOutput("security_headers_config");
        SetOutput("server_timing_headers_config");
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
    /// The cors_config attribute.
    /// </summary>
    public TerraformExpression CorsConfig => this["cors_config"];

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    public TerraformExpression CustomHeadersConfig => this["custom_headers_config"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    public TerraformExpression RemoveHeadersConfig => this["remove_headers_config"];

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    public TerraformExpression SecurityHeadersConfig => this["security_headers_config"];

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    public TerraformExpression ServerTimingHeadersConfig => this["server_timing_headers_config"];

}
