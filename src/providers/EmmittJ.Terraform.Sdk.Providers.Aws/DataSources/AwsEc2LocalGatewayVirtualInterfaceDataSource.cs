using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock
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
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_local_gateway_virtual_interface.
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSource : TerraformDataSource
{
    public AwsEc2LocalGatewayVirtualInterfaceDataSource(string name) : base("aws_ec2_local_gateway_virtual_interface", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The local_address attribute.
    /// </summary>
    [TerraformPropertyName("local_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LocalAddress => new TerraformReference(this, "local_address");

    /// <summary>
    /// The local_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("local_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LocalBgpAsn => new TerraformReference(this, "local_bgp_asn");

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LocalGatewayId => new TerraformReference(this, "local_gateway_id");

    /// <summary>
    /// The local_gateway_virtual_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_virtual_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LocalGatewayVirtualInterfaceIds => new TerraformReference(this, "local_gateway_virtual_interface_ids");

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [TerraformPropertyName("peer_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerAddress => new TerraformReference(this, "peer_address");

    /// <summary>
    /// The peer_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PeerBgpAsn => new TerraformReference(this, "peer_bgp_asn");

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [TerraformPropertyName("vlan")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Vlan => new TerraformReference(this, "vlan");

}
