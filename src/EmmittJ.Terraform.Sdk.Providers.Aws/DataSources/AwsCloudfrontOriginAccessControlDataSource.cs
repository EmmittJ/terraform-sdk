using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_control.
/// </summary>
public class AwsCloudfrontOriginAccessControlDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessControlDataSource(string name) : base("aws_cloudfront_origin_access_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("origin_access_control_origin_type");
        this.DeclareOutput("signing_behavior");
        this.DeclareOutput("signing_protocol");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    public TerraformExpression OriginAccessControlOriginType => this["origin_access_control_origin_type"];

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    public TerraformExpression SigningBehavior => this["signing_behavior"];

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    public TerraformExpression SigningProtocol => this["signing_protocol"];

}
