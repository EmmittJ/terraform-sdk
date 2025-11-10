using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The local_address attribute.
    /// </summary>
    [TerraformPropertyName("local_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_address");

    /// <summary>
    /// The local_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("local_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LocalBgpAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "local_bgp_asn");

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_gateway_id");

    /// <summary>
    /// The local_gateway_virtual_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_virtual_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LocalGatewayVirtualInterfaceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "local_gateway_virtual_interface_ids");

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [TerraformPropertyName("peer_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_address");

    /// <summary>
    /// The peer_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PeerBgpAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "peer_bgp_asn");

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [TerraformPropertyName("vlan")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Vlan => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vlan");

}
