using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerConnectPeerBgpOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_asn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PeerAsn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectPeerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_connect_peer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerConnectPeer : TerraformResource
{
    public AwsNetworkmanagerConnectPeer(string name) : base("aws_networkmanager_connect_peer", name)
    {
    }

    /// <summary>
    /// The connect_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectAttachmentId is required")]
    [TerraformPropertyName("connect_attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectAttachmentId { get; set; }

    /// <summary>
    /// The core_network_address attribute.
    /// </summary>
    [TerraformPropertyName("core_network_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoreNetworkAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("inside_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InsideCidrBlocks { get; set; }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    [TerraformPropertyName("peer_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PeerAddress { get; set; }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [TerraformPropertyName("subnet_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpOptions block(s) allowed")]
    [TerraformPropertyName("bgp_options")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerConnectPeerBgpOptionsBlock>>? BgpOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkmanagerConnectPeerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Configuration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "configuration");

    /// <summary>
    /// The connect_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("connect_peer_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectPeerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connect_peer_id");

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [TerraformPropertyName("core_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_id");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformPropertyName("edge_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_location");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
