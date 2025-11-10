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
        this.WithOutput("arn");
        this.WithOutput("comment");
        this.WithOutput("cors_config");
        this.WithOutput("custom_headers_config");
        this.WithOutput("etag");
        this.WithOutput("remove_headers_config");
        this.WithOutput("security_headers_config");
        this.WithOutput("server_timing_headers_config");
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
