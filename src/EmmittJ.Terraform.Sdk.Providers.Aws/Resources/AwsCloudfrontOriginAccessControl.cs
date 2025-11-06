using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_origin_access_control resource.
/// </summary>
public class AwsCloudfrontOriginAccessControl : TerraformResource
{
    public AwsCloudfrontOriginAccessControl(string name) : base("aws_cloudfront_origin_access_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    public string? OriginAccessControlOriginType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("origin_access_control_origin_type")?.Value;
        set => this.WithProperty("origin_access_control_origin_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    public string? SigningBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_behavior")?.Value;
        set => this.WithProperty("signing_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    public string? SigningProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_protocol")?.Value;
        set => this.WithProperty("signing_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
