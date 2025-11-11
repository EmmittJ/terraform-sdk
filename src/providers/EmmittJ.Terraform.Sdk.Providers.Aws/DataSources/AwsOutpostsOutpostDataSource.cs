using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outpost.
/// </summary>
public class AwsOutpostsOutpostDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostDataSource(string name) : base("aws_outposts_outpost", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OwnerId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneId => new TerraformReference(this, "availability_zone_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleStatus => new TerraformReference(this, "lifecycle_status");

    /// <summary>
    /// The site_arn attribute.
    /// </summary>
    [TerraformPropertyName("site_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SiteArn => new TerraformReference(this, "site_arn");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformPropertyName("site_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SiteId => new TerraformReference(this, "site_id");

    /// <summary>
    /// The supported_hardware_type attribute.
    /// </summary>
    [TerraformPropertyName("supported_hardware_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SupportedHardwareType => new TerraformReference(this, "supported_hardware_type");

}
