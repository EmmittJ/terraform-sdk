using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNatGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_nat_gateway resource.
/// </summary>
public partial class AwsNatGateway : TerraformResource
{
    public AwsNatGateway(string name) : base("aws_nat_gateway", name)
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformProperty("allocation_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllocationId { get; set; }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    [TerraformProperty("connectivity_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectivityType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateIp { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    [TerraformProperty("secondary_allocation_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecondaryAllocationIds { get; set; }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ip_address_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> SecondaryPrivateIpAddressCount { get; set; }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ip_addresses")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecondaryPrivateIpAddresses { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsNatGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIp { get; }

}
