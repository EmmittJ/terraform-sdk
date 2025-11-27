using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_access_control Terraform resource.
/// Manages a aws_cloudfront_origin_access_control resource.
/// </summary>
public partial class AwsCloudfrontOriginAccessControl(string name) : TerraformResource("aws_cloudfront_origin_access_control", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginAccessControlOriginType is required")]
    public required TerraformValue<string> OriginAccessControlOriginType
    {
        get => new TerraformReference<string>(this, "origin_access_control_origin_type");
        set => SetArgument("origin_access_control_origin_type", value);
    }

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningBehavior is required")]
    public required TerraformValue<string> SigningBehavior
    {
        get => new TerraformReference<string>(this, "signing_behavior");
        set => SetArgument("signing_behavior", value);
    }

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProtocol is required")]
    public required TerraformValue<string> SigningProtocol
    {
        get => new TerraformReference<string>(this, "signing_protocol");
        set => SetArgument("signing_protocol", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

}
