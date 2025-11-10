using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcPeeringConnectionDataSourceFilterBlock : ITerraformBlock
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
public class AwsVpcPeeringConnectionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_block");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OwnerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("peer_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PeerCidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_cidr_block");

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_owner_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PeerOwnerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_owner_id");

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_vpc_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PeerVpcId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_vpc_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcPeeringConnectionDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcPeeringConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    [TerraformPropertyName("accepter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<bool>>> Accepter => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<bool>>>(ResourceAddress, "accepter");

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CidrBlockSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cidr_block_set");

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Ipv6CidrBlockSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ipv6_cidr_block_set");

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("peer_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PeerCidrBlockSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "peer_cidr_block_set");

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformPropertyName("peer_ipv6_cidr_block_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PeerIpv6CidrBlockSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "peer_ipv6_cidr_block_set");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformPropertyName("peer_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_region");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The requester attribute.
    /// </summary>
    [TerraformPropertyName("requester")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<bool>>> Requester => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<bool>>>(ResourceAddress, "requester");

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    [TerraformPropertyName("requester_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RequesterRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "requester_region");

}
