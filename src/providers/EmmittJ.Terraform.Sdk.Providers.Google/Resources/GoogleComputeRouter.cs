using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bgp in GoogleComputeRouter.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterBgpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp";

    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement. Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AdvertiseMode
    {
        get => new TerraformReference<string>(this, "advertise_mode");
        set => SetArgument("advertise_mode", value);
    }

    /// <summary>
    /// User-specified list of prefix groups to advertise in custom mode.
    /// This field can only be populated if advertiseMode is CUSTOM and
    /// is advertised to all peers of the router. These groups will be
    /// advertised in addition to any specified prefixes. Leave this field
    /// blank to advertise no custom groups.
    /// 
    /// This enum field has the one valid value: ALL_SUBNETS
    /// </summary>
    public TerraformList<string>? AdvertisedGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advertised_groups").ResolveNodes(ctx));
        set => SetArgument("advertised_groups", value);
    }

    /// <summary>
    /// Local BGP Autonomous System Number (ASN). Must be an RFC6996
    /// private ASN, either 16-bit or 32-bit. The value will be fixed for
    /// this router resource. All VPN tunnels that link to this router
    /// will have the same local ASN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// Explicitly specifies a range of valid BGP Identifiers for this Router.
    /// It is provided as a link-local IPv4 range (from 169.254.0.0/16), of
    /// size at least /30, even if the BGP sessions are over IPv6. It must
    /// not overlap with any IPv4 BGP session ranges. Other vendors commonly
    /// call this router ID.
    /// </summary>
    public TerraformValue<string> IdentifierRange
    {
        get => new TerraformReference<string>(this, "identifier_range");
        set => SetArgument("identifier_range", value);
    }

    /// <summary>
    /// The interval in seconds between BGP keepalive messages that are sent
    /// to the peer. Hold time is three times the interval at which keepalive
    /// messages are sent, and the hold time is the maximum number of seconds
    /// allowed to elapse between successive keepalive messages that BGP
    /// receives from a peer.
    /// 
    /// BGP will use the smaller of either the local hold time value or the
    /// peer&#39;s hold time value as the hold time for the BGP connection
    /// between the two peers. If set, this value must be between 20 and 60.
    /// The default is 20.
    /// </summary>
    public TerraformValue<double>? KeepaliveInterval
    {
        get => new TerraformReference<double>(this, "keepalive_interval");
        set => SetArgument("keepalive_interval", value);
    }

    /// <summary>
    /// AdvertisedIpRanges block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRouterBgpBlockAdvertisedIpRangesBlock>? AdvertisedIpRanges
    {
        get => GetArgument<TerraformSet<GoogleComputeRouterBgpBlockAdvertisedIpRangesBlock>>("advertised_ip_ranges");
        set => SetArgument("advertised_ip_ranges", value);
    }

}

/// <summary>
/// Block type for advertised_ip_ranges in GoogleComputeRouterBgpBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterBgpBlockAdvertisedIpRangesBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The IP range to advertise. The value must be a
    /// CIDR-formatted string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    public required TerraformValue<string> Range
    {
        get => new TerraformReference<string>(this, "range");
        set => SetArgument("range", value);
    }

}


/// <summary>
/// Block type for md5_authentication_keys in GoogleComputeRouter.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterMd5AuthenticationKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "md5_authentication_keys";

    /// <summary>
    /// Value of the key used for MD5 authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Name used to identify the key. Must be unique within a router.
    /// Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeRouter.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// Resource manager tags to be bound to the router. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRouter.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_router Terraform resource.
/// Manages a google_compute_router resource.
/// </summary>
public partial class GoogleComputeRouter(string name) : TerraformResource("google_compute_router", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Indicates if a router is dedicated for use with encrypted VLAN
    /// attachments (interconnectAttachments).
    /// </summary>
    public TerraformValue<bool>? EncryptedInterconnectRouter
    {
        get => new TerraformReference<bool>(this, "encrypted_interconnect_router");
        set => SetArgument("encrypted_interconnect_router", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A reference to the network to which this router belongs.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where the router resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Bgp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bgp block(s) allowed")]
    public TerraformList<GoogleComputeRouterBgpBlock>? Bgp
    {
        get => GetArgument<TerraformList<GoogleComputeRouterBgpBlock>>("bgp");
        set => SetArgument("bgp", value);
    }

    /// <summary>
    /// Md5AuthenticationKeys block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKeys block(s) allowed")]
    public TerraformList<GoogleComputeRouterMd5AuthenticationKeysBlock>? Md5AuthenticationKeys
    {
        get => GetArgument<TerraformList<GoogleComputeRouterMd5AuthenticationKeysBlock>>("md5_authentication_keys");
        set => SetArgument("md5_authentication_keys", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeRouterParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeRouterParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
