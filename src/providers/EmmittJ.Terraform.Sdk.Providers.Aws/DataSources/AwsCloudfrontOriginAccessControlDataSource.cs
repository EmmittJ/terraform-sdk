using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_access_control Terraform data source.
/// Retrieves information about a aws_cloudfront_origin_access_control.
/// </summary>
public partial class AwsCloudfrontOriginAccessControlDataSource(string name) : TerraformDataSource("aws_cloudfront_origin_access_control", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    public TerraformValue<string> OriginAccessControlOriginType
        => AsReference("origin_access_control_origin_type");

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    public TerraformValue<string> SigningBehavior
        => AsReference("signing_behavior");

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    public TerraformValue<string> SigningProtocol
        => AsReference("signing_protocol");

}
