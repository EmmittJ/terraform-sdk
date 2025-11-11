using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsNatGatewayDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_nat_gateway.
/// </summary>
public class AwsNatGatewayDataSource : TerraformDataSource
{
    public AwsNatGatewayDataSource(string name) : base("aws_nat_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> State { get; set; } = default!;

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetId { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpcId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsNatGatewayDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNatGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AllocationId => new TerraformReference(this, "allocation_id");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationId => new TerraformReference(this, "association_id");

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectivityType => new TerraformReference(this, "connectivity_type");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkInterfaceId => new TerraformReference(this, "network_interface_id");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIp => new TerraformReference(this, "private_ip");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIp => new TerraformReference(this, "public_ip");

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    [TerraformPropertyName("secondary_allocation_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecondaryAllocationIds => new TerraformReference(this, "secondary_allocation_ids");

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ip_address_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SecondaryPrivateIpAddressCount => new TerraformReference(this, "secondary_private_ip_address_count");

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("secondary_private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecondaryPrivateIpAddresses => new TerraformReference(this, "secondary_private_ip_addresses");

}
