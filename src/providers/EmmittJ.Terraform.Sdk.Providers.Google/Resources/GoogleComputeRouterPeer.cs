using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advertised_ip_ranges in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterPeerAdvertisedIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// User-specified description for the IP range.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The IP range to advertise. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    public required TerraformProperty<string> Range
    {
        get => GetRequiredProperty<TerraformProperty<string>>("range");
        set => WithProperty("range", value);
    }

}

/// <summary>
/// Block type for bfd in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerBfdBlock : TerraformBlock
{
    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// received from the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the transmit interval of the other router. If set, this value
    /// must be between 1000 and 30000.
    /// </summary>
    public TerraformProperty<double>? MinReceiveInterval
    {
        get => GetProperty<TerraformProperty<double>>("min_receive_interval");
        set => WithProperty("min_receive_interval", value);
    }

    /// <summary>
    /// The minimum interval, in milliseconds, between BFD control packets
    /// transmitted to the peer router. The actual value is negotiated
    /// between the two routers and is equal to the greater of this value
    /// and the corresponding receive interval of the other router. If set,
    /// this value must be between 1000 and 30000.
    /// </summary>
    public TerraformProperty<double>? MinTransmitInterval
    {
        get => GetProperty<TerraformProperty<double>>("min_transmit_interval");
        set => WithProperty("min_transmit_interval", value);
    }

    /// <summary>
    /// The number of consecutive BFD packets that must be missed before
    /// BFD declares that a peer is unavailable. If set, the value must
    /// be a value between 5 and 16.
    /// </summary>
    public TerraformProperty<double>? Multiplier
    {
        get => GetProperty<TerraformProperty<double>>("multiplier");
        set => WithProperty("multiplier", value);
    }

    /// <summary>
    /// The BFD session initialization mode for this BGP peer.
    /// If set to &#39;ACTIVE&#39;, the Cloud Router will initiate the BFD session
    /// for this BGP peer. If set to &#39;PASSIVE&#39;, the Cloud Router will wait
    /// for the peer router to initiate the BFD session for this BGP peer.
    /// If set to &#39;DISABLED&#39;, BFD is disabled for this BGP peer. Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;PASSIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionInitializationMode is required")]
    public required TerraformProperty<string> SessionInitializationMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("session_initialization_mode");
        set => WithProperty("session_initialization_mode", value);
    }

}

/// <summary>
/// Block type for custom_learned_ip_ranges in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerCustomLearnedIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// The IP range to learn. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    public required TerraformProperty<string> Range
    {
        get => GetRequiredProperty<TerraformProperty<string>>("range");
        set => WithProperty("range", value);
    }

}

/// <summary>
/// Block type for md5_authentication_key in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterPeerMd5AuthenticationKeyBlock : TerraformBlock
{
    /// <summary>
    /// Value of the key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// [REQUIRED] Name used to identify the key.
    /// Must be unique within a router. Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterPeerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_router_peer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouterPeer : TerraformResource
{
    public GoogleComputeRouterPeer(string name) : base("google_compute_router_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("is_advertised_route_priority_set");
        this.WithOutput("is_custom_learned_priority_set");
        this.WithOutput("management_type");
    }

    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement.
    /// Valid values of this enum field are: &#39;DEFAULT&#39;, &#39;CUSTOM&#39; Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AdvertiseMode
    {
        get => GetProperty<TerraformProperty<string>>("advertise_mode");
        set => this.WithProperty("advertise_mode", value);
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
    public List<TerraformProperty<string>>? AdvertisedGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("advertised_groups");
        set => this.WithProperty("advertised_groups", value);
    }

    /// <summary>
    /// The priority of routes advertised to this BGP peer.
    /// Where there is more than one matching route of maximum
    /// length, the routes with the lowest priority value win.
    /// </summary>
    public TerraformProperty<double>? AdvertisedRoutePriority
    {
        get => GetProperty<TerraformProperty<double>>("advertised_route_priority");
        set => this.WithProperty("advertised_route_priority", value);
    }

    /// <summary>
    /// The user-defined custom learned route priority for a BGP session.
    /// This value is applied to all custom learned route ranges for the session. You can choose a value
    /// from 0 to 65335. If you don&#39;t provide a value, Google Cloud assigns a priority of 100 to the ranges.
    /// </summary>
    public TerraformProperty<double>? CustomLearnedRoutePriority
    {
        get => GetProperty<TerraformProperty<double>>("custom_learned_route_priority");
        set => this.WithProperty("custom_learned_route_priority", value);
    }

    /// <summary>
    /// The status of the BGP peer connection. If set to false, any active session
    /// with the peer is terminated and all associated routing information is removed.
    /// If set to true, the peer connection can be established with routing information.
    /// The default is true.
    /// </summary>
    public TerraformProperty<bool>? Enable
    {
        get => GetProperty<TerraformProperty<bool>>("enable");
        set => this.WithProperty("enable", value);
    }

    /// <summary>
    /// Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.
    /// </summary>
    public TerraformProperty<bool>? EnableIpv4
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ipv4");
        set => this.WithProperty("enable_ipv4", value);
    }

    /// <summary>
    /// Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.
    /// </summary>
    public TerraformProperty<bool>? EnableIpv6
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ipv6");
        set => this.WithProperty("enable_ipv6", value);
    }

    /// <summary>
    /// routers.list of export policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.
    /// </summary>
    public List<TerraformProperty<string>>? ExportPolicies
    {
        get => GetProperty<List<TerraformProperty<string>>>("export_policies");
        set => this.WithProperty("export_policies", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// routers.list of import policies applied to this peer, in the order they must be evaluated. 
    /// The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.
    /// </summary>
    public List<TerraformProperty<string>>? ImportPolicies
    {
        get => GetProperty<List<TerraformProperty<string>>>("import_policies");
        set => this.WithProperty("import_policies", value);
    }

    /// <summary>
    /// Name of the interface the BGP peer is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interface is required")]
    public required TerraformProperty<string> Interface
    {
        get => GetRequiredProperty<TerraformProperty<string>>("interface");
        set => this.WithProperty("interface", value);
    }

    /// <summary>
    /// IP address of the interface inside Google Cloud Platform.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// IPv4 address of the interface inside Google Cloud Platform.
    /// </summary>
    public TerraformProperty<string>? Ipv4NexthopAddress
    {
        get => GetProperty<TerraformProperty<string>>("ipv4_nexthop_address");
        set => this.WithProperty("ipv4_nexthop_address", value);
    }

    /// <summary>
    /// IPv6 address of the interface inside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    public TerraformProperty<string>? Ipv6NexthopAddress
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_nexthop_address");
        set => this.WithProperty("ipv6_nexthop_address", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Peer BGP Autonomous System Number (ASN).
    /// Each BGP interface may use a different value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformProperty<double> PeerAsn
    {
        get => GetRequiredProperty<TerraformProperty<double>>("peer_asn");
        set => this.WithProperty("peer_asn", value);
    }

    /// <summary>
    /// IP address of the BGP interface outside Google Cloud Platform.
    /// Only IPv4 is supported. Required if &#39;ip_address&#39; is set.
    /// </summary>
    public TerraformProperty<string>? PeerIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("peer_ip_address");
        set => this.WithProperty("peer_ip_address", value);
    }

    /// <summary>
    /// IPv4 address of the BGP interface outside Google Cloud Platform.
    /// </summary>
    public TerraformProperty<string>? PeerIpv4NexthopAddress
    {
        get => GetProperty<TerraformProperty<string>>("peer_ipv4_nexthop_address");
        set => this.WithProperty("peer_ipv4_nexthop_address", value);
    }

    /// <summary>
    /// IPv6 address of the BGP interface outside Google Cloud Platform.
    /// The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64.
    /// If you do not specify the next hop addresses, Google Cloud automatically
    /// assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.
    /// </summary>
    public TerraformProperty<string>? PeerIpv6NexthopAddress
    {
        get => GetProperty<TerraformProperty<string>>("peer_ipv6_nexthop_address");
        set => this.WithProperty("peer_ipv6_nexthop_address", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the router and BgpPeer reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this BgpPeer will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformProperty<string> Router
    {
        get => GetRequiredProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// The URI of the VM instance that is used as third-party router appliances
    /// such as Next Gen Firewalls, Virtual Routers, or Router Appliances.
    /// The VM instance must be located in zones contained in the same region as
    /// this Cloud Router. The VM instance is the peer side of the BGP session.
    /// </summary>
    public TerraformProperty<string>? RouterApplianceInstance
    {
        get => GetProperty<TerraformProperty<string>>("router_appliance_instance");
        set => this.WithProperty("router_appliance_instance", value);
    }

    /// <summary>
    /// Force the advertised_route_priority to be 0.
    /// </summary>
    public TerraformProperty<bool>? ZeroAdvertisedRoutePriority
    {
        get => GetProperty<TerraformProperty<bool>>("zero_advertised_route_priority");
        set => this.WithProperty("zero_advertised_route_priority", value);
    }

    /// <summary>
    /// Force the custom_learned_route_priority to be 0.
    /// </summary>
    public TerraformProperty<bool>? ZeroCustomLearnedRoutePriority
    {
        get => GetProperty<TerraformProperty<bool>>("zero_custom_learned_route_priority");
        set => this.WithProperty("zero_custom_learned_route_priority", value);
    }

    /// <summary>
    /// Block for advertised_ip_ranges.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRouterPeerAdvertisedIpRangesBlock>? AdvertisedIpRanges
    {
        get => GetProperty<HashSet<GoogleComputeRouterPeerAdvertisedIpRangesBlock>>("advertised_ip_ranges");
        set => this.WithProperty("advertised_ip_ranges", value);
    }

    /// <summary>
    /// Block for bfd.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bfd block(s) allowed")]
    public List<GoogleComputeRouterPeerBfdBlock>? Bfd
    {
        get => GetProperty<List<GoogleComputeRouterPeerBfdBlock>>("bfd");
        set => this.WithProperty("bfd", value);
    }

    /// <summary>
    /// Block for custom_learned_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRouterPeerCustomLearnedIpRangesBlock>? CustomLearnedIpRanges
    {
        get => GetProperty<List<GoogleComputeRouterPeerCustomLearnedIpRangesBlock>>("custom_learned_ip_ranges");
        set => this.WithProperty("custom_learned_ip_ranges", value);
    }

    /// <summary>
    /// Block for md5_authentication_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKey block(s) allowed")]
    public List<GoogleComputeRouterPeerMd5AuthenticationKeyBlock>? Md5AuthenticationKey
    {
        get => GetProperty<List<GoogleComputeRouterPeerMd5AuthenticationKeyBlock>>("md5_authentication_key");
        set => this.WithProperty("md5_authentication_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterPeerTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRouterPeerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// An internal boolean field for provider use for zero_advertised_route_priority.
    /// </summary>
    public TerraformExpression IsAdvertisedRoutePrioritySet => this["is_advertised_route_priority_set"];

    /// <summary>
    /// An internal boolean field for provider use.
    /// </summary>
    public TerraformExpression IsCustomLearnedPrioritySet => this["is_custom_learned_priority_set"];

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
    public TerraformExpression ManagementType => this["management_type"];

}
