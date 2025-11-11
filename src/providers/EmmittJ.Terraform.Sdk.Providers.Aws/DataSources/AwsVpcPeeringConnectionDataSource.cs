using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcPeeringConnectionDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcPeeringConnectionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_peering_connection.
/// </summary>
public partial class AwsVpcPeeringConnectionDataSource : TerraformDataSource
{
    public AwsVpcPeeringConnectionDataSource(string name) : base("aws_vpc_peering_connection", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CidrBlock { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OwnerId { get; set; }

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    [TerraformProperty("peer_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeerCidrBlock { get; set; }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    [TerraformProperty("peer_owner_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeerOwnerId { get; set; }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [TerraformProperty("peer_vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeerVpcId { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsVpcPeeringConnectionDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcPeeringConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    [TerraformProperty("accepter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<bool> Accepter { get; }

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    [TerraformProperty("cidr_block_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CidrBlockSet { get; }

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Ipv6CidrBlockSet { get; }

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    [TerraformProperty("peer_cidr_block_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PeerCidrBlockSet { get; }

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    [TerraformProperty("peer_ipv6_cidr_block_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PeerIpv6CidrBlockSet { get; }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformProperty("peer_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerRegion { get; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// The requester attribute.
    /// </summary>
    [TerraformProperty("requester")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<bool> Requester { get; }

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    [TerraformProperty("requester_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RequesterRegion { get; }

}
