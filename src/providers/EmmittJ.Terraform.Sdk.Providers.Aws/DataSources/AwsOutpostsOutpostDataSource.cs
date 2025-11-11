using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outpost.
/// </summary>
public partial class AwsOutpostsOutpostDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostDataSource(string name) : base("aws_outposts_outpost", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OwnerId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    [TerraformProperty("lifecycle_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleStatus { get; }

    /// <summary>
    /// The site_arn attribute.
    /// </summary>
    [TerraformProperty("site_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SiteArn { get; }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformProperty("site_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SiteId { get; }

    /// <summary>
    /// The supported_hardware_type attribute.
    /// </summary>
    [TerraformProperty("supported_hardware_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SupportedHardwareType { get; }

}
