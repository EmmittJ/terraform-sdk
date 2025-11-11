using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for openzfs_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock
{
    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    [TerraformPropertyName("volume_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VolumeId { get; set; }

}

/// <summary>
/// Block type for s3_access_point in .
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentS3AccessPointBlock
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxS3AccessPointAttachmentTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_fsx_s3_access_point_attachment resource.
/// </summary>
public class AwsFsxS3AccessPointAttachment : TerraformResource
{
    public AwsFsxS3AccessPointAttachment(string name) : base("aws_fsx_s3_access_point_attachment", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for openzfs_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("openzfs_configuration")]
    public TerraformList<TerraformBlock<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock>>? OpenzfsConfiguration { get; set; }

    /// <summary>
    /// Block for s3_access_point.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("s3_access_point")]
    public TerraformList<TerraformBlock<AwsFsxS3AccessPointAttachmentS3AccessPointBlock>>? S3AccessPoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxS3AccessPointAttachmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The s3_access_point_alias attribute.
    /// </summary>
    [TerraformPropertyName("s3_access_point_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3AccessPointAlias => new TerraformReference(this, "s3_access_point_alias");

    /// <summary>
    /// The s3_access_point_arn attribute.
    /// </summary>
    [TerraformPropertyName("s3_access_point_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3AccessPointArn => new TerraformReference(this, "s3_access_point_arn");

}
