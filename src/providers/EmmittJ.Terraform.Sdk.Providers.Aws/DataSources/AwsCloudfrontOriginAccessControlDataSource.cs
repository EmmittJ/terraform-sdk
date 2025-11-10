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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("etag");
        SetOutput("name");
        SetOutput("origin_access_control_origin_type");
        SetOutput("signing_behavior");
        SetOutput("signing_protocol");
        SetOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
