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
        this.DeclareOutput("arn");
        this.DeclareOutput("comment");
        this.DeclareOutput("cors_config");
        this.DeclareOutput("custom_headers_config");
        this.DeclareOutput("etag");
        this.DeclareOutput("remove_headers_config");
        this.DeclareOutput("security_headers_config");
        this.DeclareOutput("server_timing_headers_config");
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
