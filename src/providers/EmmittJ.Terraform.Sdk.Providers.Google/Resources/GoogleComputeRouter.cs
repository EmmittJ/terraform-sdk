using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bgp in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterBgpBlock : TerraformBlock
{
    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement. Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AdvertiseMode
    {
        get => GetProperty<TerraformProperty<string>>("advertise_mode");
        set => WithProperty("advertise_mode", value);
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
    public List<TerraformProperty<string>>? AdvertisedGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("advertised_groups");
        set => WithProperty("advertised_groups", value);
    }

    /// <summary>
    /// Local BGP Autonomous System Number (ASN). Must be an RFC6996
    /// private ASN, either 16-bit or 32-bit. The value will be fixed for
    /// this router resource. All VPN tunnels that link to this router
    /// will have the same local ASN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformProperty<double> Asn
    {
        get => GetRequiredProperty<TerraformProperty<double>>("asn");
        set => WithProperty("asn", value);
    }

    /// <summary>
    /// Explicitly specifies a range of valid BGP Identifiers for this Router.
    /// It is provided as a link-local IPv4 range (from 169.254.0.0/16), of
    /// size at least /30, even if the BGP sessions are over IPv6. It must
    /// not overlap with any IPv4 BGP session ranges. Other vendors commonly
    /// call this router ID.
    /// </summary>
    public TerraformProperty<string>? IdentifierRange
    {
        get => GetProperty<TerraformProperty<string>>("identifier_range");
        set => WithProperty("identifier_range", value);
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
    public TerraformProperty<double>? KeepaliveInterval
    {
        get => GetProperty<TerraformProperty<double>>("keepalive_interval");
        set => WithProperty("keepalive_interval", value);
    }

}

/// <summary>
/// Block type for md5_authentication_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterMd5AuthenticationKeysBlock : TerraformBlock
{
    /// <summary>
    /// Value of the key used for MD5 authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// Name used to identify the key. Must be unique within a router.
    /// Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterParamsBlock : TerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the router. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => WithProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_router resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouter : TerraformResource
{
    public GoogleComputeRouter(string name) : base("google_compute_router", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_timestamp");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Indicates if a router is dedicated for use with encrypted VLAN
    /// attachments (interconnectAttachments).
    /// </summary>
    public TerraformProperty<bool>? EncryptedInterconnectRouter
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted_interconnect_router");
        set => this.WithProperty("encrypted_interconnect_router", value);
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
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
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
    /// A reference to the network to which this router belongs.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
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
    /// Region where the router resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for bgp.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bgp block(s) allowed")]
    public List<GoogleComputeRouterBgpBlock>? Bgp
    {
        get => GetProperty<List<GoogleComputeRouterBgpBlock>>("bgp");
        set => this.WithProperty("bgp", value);
    }

    /// <summary>
    /// Block for md5_authentication_keys.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKeys block(s) allowed")]
    public List<GoogleComputeRouterMd5AuthenticationKeysBlock>? Md5AuthenticationKeys
    {
        get => GetProperty<List<GoogleComputeRouterMd5AuthenticationKeysBlock>>("md5_authentication_keys");
        set => this.WithProperty("md5_authentication_keys", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeRouterParamsBlock>? Params
    {
        get => GetProperty<List<GoogleComputeRouterParamsBlock>>("params");
        set => this.WithProperty("params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRouterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
