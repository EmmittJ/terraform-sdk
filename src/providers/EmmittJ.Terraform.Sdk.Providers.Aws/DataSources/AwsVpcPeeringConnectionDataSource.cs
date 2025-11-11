using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcPeeringConnectionDataSourceFilterBlock
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
public class AwsVpcPeeringConnectionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_peering_connection.
/// </summary>
public class AwsVpcPeeringConnectionDataSource : TerraformDataSource
{
    public AwsVpcPeeringConnectionDataSource(string name) : base("aws_vpc_peering_connection", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CidrBlock { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OwnerId { get; set; } = default!;

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("peer_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeerCidrBlock { get; set; } = default!;

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_owner_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeerOwnerId { get; set; } = default!;

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_vpc_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeerVpcId { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

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
    public TerraformSet<TerraformBlock<AwsVpcPeeringConnectionDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcPeeringConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    [TerraformPropertyName("accepter")]
    // Output-only attribute - read-only reference
    public TerraformMap<bool> Accepter => new TerraformReference(this, "accepter");

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CidrBlockSet => new TerraformReference(this, "cidr_block_set");

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Ipv6CidrBlockSet => new TerraformReference(this, "ipv6_cidr_block_set");

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("peer_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PeerCidrBlockSet => new TerraformReference(this, "peer_cidr_block_set");

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("peer_ipv6_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PeerIpv6CidrBlockSet => new TerraformReference(this, "peer_ipv6_cidr_block_set");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformPropertyName("peer_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerRegion => new TerraformReference(this, "peer_region");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The requester attribute.
    /// </summary>
    [TerraformPropertyName("requester")]
    // Output-only attribute - read-only reference
    public TerraformMap<bool> Requester => new TerraformReference(this, "requester");

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    [TerraformPropertyName("requester_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RequesterRegion => new TerraformReference(this, "requester_region");

}
