using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_control.
/// </summary>
public partial class AwsCloudfrontOriginAccessControlDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessControlDataSource(string name) : base("aws_cloudfront_origin_access_control", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    [TerraformProperty("origin_access_control_origin_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OriginAccessControlOriginType { get; }

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    [TerraformProperty("signing_behavior")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningBehavior { get; }

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    [TerraformProperty("signing_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningProtocol { get; }

}
