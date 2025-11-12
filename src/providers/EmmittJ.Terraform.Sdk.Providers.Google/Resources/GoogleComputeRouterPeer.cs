using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advertised_ip_ranges in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeRouterPeerAdvertisedIpRangesBlock() : TerraformBlock("advertised_ip_ranges")
{
    /// <summary>
    /// User-specified description for the IP range.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The IP range to advertise. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [TerraformProperty("range")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Range { get; set; }

}

/// <summary>
/// Block type for bfd in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRouterPeerBfdBlock() : TerraformBlock("bfd")
{
    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// received from the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the transmit interval of the other router. If set, this value
    /// must be between 1000 and 30000.
    /// </summary>
    [TerraformProperty("min_receive_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinReceiveInterval { get; set; }

    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// transmitted to the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the corresponding receive interval of the other router. If set,
    /// this value must be between 1000 and 30000.
    /// </summary>
    [TerraformProperty("min_transmit_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTransmitInterval { get; set; }

    /// <summary>
    /// The number of consecutive BFD packets that must be missed before
    /// BFD declares that a peer is unavailable. If set, the value must
    /// be a value between 5 and 16.
    /// </summary>
    [TerraformProperty("multiplier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Multiplier { get; set; }

    /// <summary>
    /// The BFD session initialization mode for this BGP peer.
    /// If set to &#39;ACTIVE&#39;, the Cloud Router will initiate the BFD session
    /// for this BGP peer. If set to &#39;PASSIVE&#39;, the Cloud Router will wait
    /// for the peer router to initiate the BFD session for this BGP peer.
    /// If set to &#39;DISABLED&#39;, BFD is disabled for this BGP peer. Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;PASSIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionInitializationMode is required")]
    [TerraformProperty("session_initialization_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SessionInitializationMode { get; set; }

}

/// <summary>
/// Block type for custom_learned_ip_ranges in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRouterPeerCustomLearnedIpRangesBlock() : TerraformBlock("custom_learned_ip_ranges")
{
    /// <summary>
    /// The IP range to learn. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [TerraformProperty("range")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Range { get; set; }

}

/// <summary>
/// Block type for md5_authentication_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRouterPeerMd5AuthenticationKeyBlock() : TerraformBlock("md5_authentication_key")
{
    /// <summary>
    /// Value of the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// [REQUIRED] Name used to identify the key.
    /// Must be unique within a router. Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRouterPeerTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_router_peer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRouterPeer : TerraformResource
{
    public GoogleComputeRouterPeer(string name) : base("google_compute_router_peer", name)
    {
    }

    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement.
    /// Valid values of this enum field are: &#39;DEFAULT&#39;, &#39;CUSTOM&#39; Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [TerraformProperty("advertise_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdvertiseMode { get; set; }

    /// <summary>
    /// User-specified list of prefix groups to advertise in custom
    /// mode, which currently supports the following option:
    /// 
    /// * &#39;ALL_SUBNETS&#39;: Advertises all of the router&#39;s own VPC subnets.
    /// This excludes any routes learned for subnets that use VPC Network
    /// Peering.
    /// 
    /// 
    /// Note that this field can only be populated if advertiseMode is &#39;CUSTOM&#39;
    /// and overrides the list defined for the router (in the &amp;quot;bgp&amp;quot; message).
    /// These groups are advertised in addition to any specified prefixes.
    /// Leave this field blank to advertise no custom groups.
    /// </summary>
    [TerraformProperty("advertised_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdvertisedGroups { get; set; }

    /// <summary>
    /// The priority of routes advertised to this BGP peer.
    /// Where there is more than one matching route of maximum
    /// length, the routes with the lowest priority value win.
    /// </summary>
    [TerraformProperty("advertised_route_priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdvertisedRoutePriority { get; set; }

    /// <summary>
    /// The user-defined custom learned route priority for a BGP session.
    /// This value is applied to all custom learned route ranges for the session. You can choose a value
    /// from 0 to 65335. If you don&#39;t provide a value, Google Cloud assigns a priority of 100 to the ranges.
    /// </summary>
    [TerraformProperty("custom_learned_route_priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CustomLearnedRoutePriority { get; set; }

    /// <summary>
    /// The status of the BGP peer connection. If set to false, any active session
    /// with the peer is terminated and all associated routing information is removed.
    /// If set to true, the peer connection can be established with routing information.
    /// The default is true.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enable { get; set; }

    /// <summary>
    /// Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.
    /// </summary>
    [TerraformProperty("enable_ipv4")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableIpv4 { get; set; }

    /// <summary>
    /// Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.
    /// </summary>
    [TerraformProperty("enable_ipv6")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableIpv6 { get; set; }

    /// <summary>
    /// routers.list of export policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.
    /// </summary>
    [TerraformProperty("export_policies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExportPolicies { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// routers.list of import policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.
    /// </summary>
    [TerraformProperty("import_policies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ImportPolicies { get; set; }

    /// <summary>
    /// Name of the interface the BGP peer is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    [TerraformProperty("interface")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Interface { get; set; }

    /// <summary>
    /// IP address of the interface inside Google Cloud Platform.
    /// Only IPv4 is supported.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// IPv4 address of the interface inside Google Cloud Platform.
    /// </summary>
    [TerraformProperty("ipv4_nexthop_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv4NexthopAddress { get; set; }

    /// <summary>
    /// IPv6 address of the interface inside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    [TerraformProperty("ipv6_nexthop_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6NexthopAddress { get; set; }

    /// <summary>
    /// Name of this BGP peer. The name must be 1-63 characters long,
    /// and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Peer BGP Autonomous System Number (ASN).
    /// Each BGP interface may use a different value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    [TerraformProperty("peer_asn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> PeerAsn { get; set; }

    /// <summary>
    /// IP address of the BGP interface outside Google Cloud Platform.
    /// Only IPv4 is supported. Required if &#39;ip_address&#39; is set.
    /// </summary>
    [TerraformProperty("peer_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerIpAddress { get; set; }

    /// <summary>
    /// IPv4 address of the BGP interface outside Google Cloud Platform.
    /// </summary>
    [TerraformProperty("peer_ipv4_nexthop_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerIpv4NexthopAddress { get; set; }

    /// <summary>
    /// IPv6 address of the BGP interface outside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    [TerraformProperty("peer_ipv6_nexthop_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerIpv6NexthopAddress { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the router and BgpPeer reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name of the Cloud Router in which this BgpPeer will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformProperty("router")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Router { get; set; }

    /// <summary>
    /// The URI of the VM instance that is used as third-party router appliances
    /// such as Next Gen Firewalls, Virtual Routers, or Router Appliances.
    /// The VM instance must be located in zones contained in the same region as
    /// this Cloud Router. The VM instance is the peer side of the BGP session.
    /// </summary>
    [TerraformProperty("router_appliance_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RouterApplianceInstance { get; set; }

    /// <summary>
    /// Force the advertised_route_priority to be 0.
    /// </summary>
    [TerraformProperty("zero_advertised_route_priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZeroAdvertisedRoutePriority { get; set; }

    /// <summary>
    /// Force the custom_learned_route_priority to be 0.
    /// </summary>
    [TerraformProperty("zero_custom_learned_route_priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZeroCustomLearnedRoutePriority { get; set; }

    /// <summary>
    /// Block for advertised_ip_ranges.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("advertised_ip_ranges")]
    public TerraformSet<GoogleComputeRouterPeerAdvertisedIpRangesBlock> AdvertisedIpRanges { get; set; } = new();

    /// <summary>
    /// Block for bfd.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bfd block(s) allowed")]
    [TerraformProperty("bfd")]
    public TerraformList<GoogleComputeRouterPeerBfdBlock> Bfd { get; set; } = new();

    /// <summary>
    /// Block for custom_learned_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_learned_ip_ranges")]
    public TerraformList<GoogleComputeRouterPeerCustomLearnedIpRangesBlock> CustomLearnedIpRanges { get; set; } = new();

    /// <summary>
    /// Block for md5_authentication_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKey block(s) allowed")]
    [TerraformProperty("md5_authentication_key")]
    public TerraformList<GoogleComputeRouterPeerMd5AuthenticationKeyBlock> Md5AuthenticationKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeRouterPeerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// An internal boolean field for provider use for zero_advertised_route_priority.
    /// </summary>
    [TerraformProperty("is_advertised_route_priority_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsAdvertisedRoutePrioritySet { get; }

    /// <summary>
    /// An internal boolean field for provider use.
    /// </summary>
    [TerraformProperty("is_custom_learned_priority_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsCustomLearnedPrioritySet { get; }

    /// <summary>
    /// The resource that configures and manages this BGP peer.
    /// 
    /// * &#39;MANAGED_BY_USER&#39; is the default value and can be managed by
    /// you or other users
    /// * &#39;MANAGED_BY_ATTACHMENT&#39; is a BGP peer that is configured and
    /// managed by Cloud Interconnect, specifically by an
    /// InterconnectAttachment of type PARTNER. Google automatically
    /// creates, updates, and deletes this type of BGP peer when the
    /// PARTNER InterconnectAttachment is created, updated,
    /// or deleted.
    /// </summary>
    [TerraformProperty("management_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagementType { get; }

}
