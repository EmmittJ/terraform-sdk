using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsNatGatewayDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNatGatewayDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_nat_gateway.
/// </summary>
public partial class AwsNatGatewayDataSource : TerraformDataSource
{
    public AwsNatGatewayDataSource(string name) : base("aws_nat_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsNatGatewayDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNatGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformProperty("allocation_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AllocationId { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    [TerraformProperty("connectivity_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectivityType { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIp { get; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIp { get; }

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    [TerraformProperty("secondary_allocation_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SecondaryAllocationIds { get; }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ip_address_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SecondaryPrivateIpAddressCount { get; }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("secondary_private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SecondaryPrivateIpAddresses { get; }

}
