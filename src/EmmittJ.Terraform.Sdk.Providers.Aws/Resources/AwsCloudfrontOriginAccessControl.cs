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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    public TerraformProperty<string>? OriginAccessControlOriginType
    {
        get => GetProperty<TerraformProperty<string>>("origin_access_control_origin_type");
        set => this.WithProperty("origin_access_control_origin_type", value);
    }

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? SigningBehavior
    {
        get => GetProperty<TerraformProperty<string>>("signing_behavior");
        set => this.WithProperty("signing_behavior", value);
    }

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? SigningProtocol
    {
        get => GetProperty<TerraformProperty<string>>("signing_protocol");
        set => this.WithProperty("signing_protocol", value);
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
