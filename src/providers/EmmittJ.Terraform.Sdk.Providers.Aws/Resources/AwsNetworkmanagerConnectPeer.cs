using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerConnectPeerBgpOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformProperty("peer_asn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PeerAsn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerConnectPeerTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_networkmanager_connect_peer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkmanagerConnectPeer : TerraformResource
{
    public AwsNetworkmanagerConnectPeer(string name) : base("aws_networkmanager_connect_peer", name)
    {
    }

    /// <summary>
    /// The connect_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectAttachmentId is required")]
    [TerraformProperty("connect_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectAttachmentId { get; set; }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    [TerraformProperty("core_network_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CoreNetworkAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("inside_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InsideCidrBlocks { get; set; }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    [TerraformProperty("peer_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerAddress { get; set; }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [TerraformProperty("subnet_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetArn { get; set; }

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
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpOptions block(s) allowed")]
    [TerraformProperty("bgp_options")]
    public partial TerraformList<TerraformBlock<AwsNetworkmanagerConnectPeerBgpOptionsBlock>>? BgpOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkmanagerConnectPeerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformProperty("configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Configuration { get; }

    /// <summary>
    /// The connect_peer_id attribute.
    /// </summary>
    [TerraformProperty("connect_peer_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectPeerId { get; }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [TerraformProperty("core_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkId { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformProperty("edge_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EdgeLocation { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
