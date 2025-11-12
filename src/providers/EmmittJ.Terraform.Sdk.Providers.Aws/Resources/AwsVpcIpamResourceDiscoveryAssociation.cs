using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipam_resource_discovery_association resource.
/// </summary>
public partial class AwsVpcIpamResourceDiscoveryAssociation : TerraformResource
{
    public AwsVpcIpamResourceDiscoveryAssociation(string name) : base("aws_vpc_ipam_resource_discovery_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamId is required")]
    [TerraformProperty("ipam_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamId { get; set; }

    /// <summary>
    /// The ipam_resource_discovery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamResourceDiscoveryId is required")]
    [TerraformProperty("ipam_resource_discovery_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamResourceDiscoveryId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ipam_arn attribute.
    /// </summary>
    [TerraformProperty("ipam_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpamArn { get; }

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    [TerraformProperty("ipam_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpamRegion { get; }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformProperty("is_default")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsDefault { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
