using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advertised_ip_ranges in GoogleComputeRouterPeer.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterPeerAdvertisedIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advertised_ip_ranges";

    /// <summary>
    /// User-specified description for the IP range.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The IP range to advertise. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    public required TerraformValue<string> Range
    {
        get => GetArgument<TerraformValue<string>>("range");
        set => SetArgument("range", value);
    }

}


/// <summary>
/// Block type for bfd in GoogleComputeRouterPeer.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerBfdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bfd";

    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// received from the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the transmit interval of the other router. If set, this value
    /// must be between 1000 and 30000.
    /// </summary>
    public TerraformValue<double>? MinReceiveInterval
    {
        get => GetArgument<TerraformValue<double>>("min_receive_interval");
        set => SetArgument("min_receive_interval", value);
    }

    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// transmitted to the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the corresponding receive interval of the other router. If set,
    /// this value must be between 1000 and 30000.
    /// </summary>
    public TerraformValue<double>? MinTransmitInterval
    {
        get => GetArgument<TerraformValue<double>>("min_transmit_interval");
        set => SetArgument("min_transmit_interval", value);
    }

    /// <summary>
    /// The number of consecutive BFD packets that must be missed before
    /// BFD declares that a peer is unavailable. If set, the value must
    /// be a value between 5 and 16.
    /// </summary>
    public TerraformValue<double>? Multiplier
    {
        get => GetArgument<TerraformValue<double>>("multiplier");
        set => SetArgument("multiplier", value);
    }

    /// <summary>
    /// The BFD session initialization mode for this BGP peer.
    /// If set to &#39;ACTIVE&#39;, the Cloud Router will initiate the BFD session
    /// for this BGP peer. If set to &#39;PASSIVE&#39;, the Cloud Router will wait
    /// for the peer router to initiate the BFD session for this BGP peer.
    /// If set to &#39;DISABLED&#39;, BFD is disabled for this BGP peer. Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;PASSIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionInitializationMode is required")]
    public required TerraformValue<string> SessionInitializationMode
    {
        get => GetArgument<TerraformValue<string>>("session_initialization_mode");
        set => SetArgument("session_initialization_mode", value);
    }

}


/// <summary>
/// Block type for custom_learned_ip_ranges in GoogleComputeRouterPeer.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerCustomLearnedIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_learned_ip_ranges";

    /// <summary>
    /// The IP range to learn. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    public required TerraformValue<string> Range
    {
        get => GetArgument<TerraformValue<string>>("range");
        set => SetArgument("range", value);
    }

}


/// <summary>
/// Block type for md5_authentication_key in GoogleComputeRouterPeer.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerMd5AuthenticationKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "md5_authentication_key";

    /// <summary>
    /// Value of the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// [REQUIRED] Name used to identify the key.
    /// Must be unique within a router. Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRouterPeer.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterPeerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_router_peer Terraform resource.
/// Manages a google_compute_router_peer resource.
/// </summary>
public partial class GoogleComputeRouterPeer(string name) : TerraformResource("google_compute_router_peer", name)
{
    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement.
    /// Valid values of this enum field are: &#39;DEFAULT&#39;, &#39;CUSTOM&#39; Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AdvertiseMode
    {
        get => GetArgument<TerraformValue<string>>("advertise_mode");
        set => SetArgument("advertise_mode", value);
    }

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
    public TerraformList<string>? AdvertisedGroups
    {
        get => GetArgument<TerraformList<string>>("advertised_groups");
        set => SetArgument("advertised_groups", value);
    }

    /// <summary>
    /// The priority of routes advertised to this BGP peer.
    /// Where there is more than one matching route of maximum
    /// length, the routes with the lowest priority value win.
    /// </summary>
    public TerraformValue<double>? AdvertisedRoutePriority
    {
        get => GetArgument<TerraformValue<double>>("advertised_route_priority");
        set => SetArgument("advertised_route_priority", value);
    }

    /// <summary>
    /// The user-defined custom learned route priority for a BGP session.
    /// This value is applied to all custom learned route ranges for the session. You can choose a value
    /// from 0 to 65335. If you don&#39;t provide a value, Google Cloud assigns a priority of 100 to the ranges.
    /// </summary>
    public TerraformValue<double>? CustomLearnedRoutePriority
    {
        get => GetArgument<TerraformValue<double>>("custom_learned_route_priority");
        set => SetArgument("custom_learned_route_priority", value);
    }

    /// <summary>
    /// The status of the BGP peer connection. If set to false, any active session
    /// with the peer is terminated and all associated routing information is removed.
    /// If set to true, the peer connection can be established with routing information.
    /// The default is true.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.
    /// </summary>
    public TerraformValue<bool>? EnableIpv4
    {
        get => GetArgument<TerraformValue<bool>>("enable_ipv4");
        set => SetArgument("enable_ipv4", value);
    }

    /// <summary>
    /// Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableIpv6
    {
        get => GetArgument<TerraformValue<bool>>("enable_ipv6");
        set => SetArgument("enable_ipv6", value);
    }

    /// <summary>
    /// routers.list of export policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.
    /// </summary>
    public TerraformList<string>? ExportPolicies
    {
        get => GetArgument<TerraformList<string>>("export_policies");
        set => SetArgument("export_policies", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// routers.list of import policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.
    /// </summary>
    public TerraformList<string>? ImportPolicies
    {
        get => GetArgument<TerraformList<string>>("import_policies");
        set => SetArgument("import_policies", value);
    }

    /// <summary>
    /// Name of the interface the BGP peer is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterfaceAttribute is required")]
    public required TerraformValue<string> InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// IP address of the interface inside Google Cloud Platform.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// IPv4 address of the interface inside Google Cloud Platform.
    /// </summary>
    public TerraformValue<string>? Ipv4NexthopAddress
    {
        get => GetArgument<TerraformValue<string>>("ipv4_nexthop_address");
        set => SetArgument("ipv4_nexthop_address", value);
    }

    /// <summary>
    /// IPv6 address of the interface inside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    public TerraformValue<string>? Ipv6NexthopAddress
    {
        get => GetArgument<TerraformValue<string>>("ipv6_nexthop_address");
        set => SetArgument("ipv6_nexthop_address", value);
    }

    /// <summary>
    /// Name of this BGP peer. The name must be 1-63 characters long,
    /// and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Peer BGP Autonomous System Number (ASN).
    /// Each BGP interface may use a different value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformValue<double> PeerAsn
    {
        get => GetArgument<TerraformValue<double>>("peer_asn");
        set => SetArgument("peer_asn", value);
    }

    /// <summary>
    /// IP address of the BGP interface outside Google Cloud Platform.
    /// Only IPv4 is supported. Required if &#39;ip_address&#39; is set.
    /// </summary>
    public TerraformValue<string>? PeerIpAddress
    {
        get => GetArgument<TerraformValue<string>>("peer_ip_address");
        set => SetArgument("peer_ip_address", value);
    }

    /// <summary>
    /// IPv4 address of the BGP interface outside Google Cloud Platform.
    /// </summary>
    public TerraformValue<string>? PeerIpv4NexthopAddress
    {
        get => GetArgument<TerraformValue<string>>("peer_ipv4_nexthop_address");
        set => SetArgument("peer_ipv4_nexthop_address", value);
    }

    /// <summary>
    /// IPv6 address of the BGP interface outside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    public TerraformValue<string>? PeerIpv6NexthopAddress
    {
        get => GetArgument<TerraformValue<string>>("peer_ipv6_nexthop_address");
        set => SetArgument("peer_ipv6_nexthop_address", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where the router and BgpPeer reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this BgpPeer will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => GetArgument<TerraformValue<string>>("router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// The URI of the VM instance that is used as third-party router appliances
    /// such as Next Gen Firewalls, Virtual Routers, or Router Appliances.
    /// The VM instance must be located in zones contained in the same region as
    /// this Cloud Router. The VM instance is the peer side of the BGP session.
    /// </summary>
    public TerraformValue<string>? RouterApplianceInstance
    {
        get => GetArgument<TerraformValue<string>>("router_appliance_instance");
        set => SetArgument("router_appliance_instance", value);
    }

    /// <summary>
    /// Force the advertised_route_priority to be 0.
    /// </summary>
    public TerraformValue<bool>? ZeroAdvertisedRoutePriority
    {
        get => GetArgument<TerraformValue<bool>>("zero_advertised_route_priority");
        set => SetArgument("zero_advertised_route_priority", value);
    }

    /// <summary>
    /// Force the custom_learned_route_priority to be 0.
    /// </summary>
    public TerraformValue<bool>? ZeroCustomLearnedRoutePriority
    {
        get => GetArgument<TerraformValue<bool>>("zero_custom_learned_route_priority");
        set => SetArgument("zero_custom_learned_route_priority", value);
    }

    /// <summary>
    /// An internal boolean field for provider use for zero_advertised_route_priority.
    /// </summary>
    public TerraformValue<bool> IsAdvertisedRoutePrioritySet
        => AsReference("is_advertised_route_priority_set");

    /// <summary>
    /// An internal boolean field for provider use.
    /// </summary>
    public TerraformValue<bool> IsCustomLearnedPrioritySet
        => AsReference("is_custom_learned_priority_set");

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
    public TerraformValue<string> ManagementType
        => AsReference("management_type");

    /// <summary>
    /// AdvertisedIpRanges block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRouterPeerAdvertisedIpRangesBlock>? AdvertisedIpRanges
    {
        get => GetArgument<TerraformSet<GoogleComputeRouterPeerAdvertisedIpRangesBlock>>("advertised_ip_ranges");
        set => SetArgument("advertised_ip_ranges", value);
    }

    /// <summary>
    /// Bfd block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bfd block(s) allowed")]
    public TerraformList<GoogleComputeRouterPeerBfdBlock>? Bfd
    {
        get => GetArgument<TerraformList<GoogleComputeRouterPeerBfdBlock>>("bfd");
        set => SetArgument("bfd", value);
    }

    /// <summary>
    /// CustomLearnedIpRanges block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRouterPeerCustomLearnedIpRangesBlock>? CustomLearnedIpRanges
    {
        get => GetArgument<TerraformList<GoogleComputeRouterPeerCustomLearnedIpRangesBlock>>("custom_learned_ip_ranges");
        set => SetArgument("custom_learned_ip_ranges", value);
    }

    /// <summary>
    /// Md5AuthenticationKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKey block(s) allowed")]
    public TerraformList<GoogleComputeRouterPeerMd5AuthenticationKeyBlock>? Md5AuthenticationKey
    {
        get => GetArgument<TerraformList<GoogleComputeRouterPeerMd5AuthenticationKeyBlock>>("md5_authentication_key");
        set => SetArgument("md5_authentication_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
