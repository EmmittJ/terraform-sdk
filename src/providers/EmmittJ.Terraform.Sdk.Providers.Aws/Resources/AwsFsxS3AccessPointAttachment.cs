using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for openzfs_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    [TerraformProperty("volume_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeId { get; set; }

}

/// <summary>
/// Block type for s3_access_point in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxS3AccessPointAttachmentS3AccessPointBlock : TerraformBlockBase
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxS3AccessPointAttachmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_fsx_s3_access_point_attachment resource.
/// </summary>
public partial class AwsFsxS3AccessPointAttachment : TerraformResource
{
    public AwsFsxS3AccessPointAttachment(string name) : base("aws_fsx_s3_access_point_attachment", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for openzfs_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("openzfs_configuration")]
    public partial TerraformList<TerraformBlock<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock>>? OpenzfsConfiguration { get; set; }

    /// <summary>
    /// Block for s3_access_point.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("s3_access_point")]
    public partial TerraformList<TerraformBlock<AwsFsxS3AccessPointAttachmentS3AccessPointBlock>>? S3AccessPoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFsxS3AccessPointAttachmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The s3_access_point_alias attribute.
    /// </summary>
    [TerraformProperty("s3_access_point_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3AccessPointAlias { get; }

    /// <summary>
    /// The s3_access_point_arn attribute.
    /// </summary>
    [TerraformProperty("s3_access_point_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3AccessPointArn { get; }

}
