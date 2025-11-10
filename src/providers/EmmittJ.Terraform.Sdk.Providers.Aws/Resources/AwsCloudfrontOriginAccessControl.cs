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
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("origin_access_control_origin_type");
        SetOutput("signing_behavior");
        SetOutput("signing_protocol");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginAccessControlOriginType is required")]
    public required TerraformProperty<string> OriginAccessControlOriginType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin_access_control_origin_type");
        set => SetProperty("origin_access_control_origin_type", value);
    }

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningBehavior is required")]
    public required TerraformProperty<string> SigningBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signing_behavior");
        set => SetProperty("signing_behavior", value);
    }

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProtocol is required")]
    public required TerraformProperty<string> SigningProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signing_protocol");
        set => SetProperty("signing_protocol", value);
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
