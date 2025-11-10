using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bgp in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterBgpBlock : ITerraformBlock
{
    /// <summary>
    /// User-specified flag to indicate which mode to use for advertisement. Default value: &amp;quot;DEFAULT&amp;quot; Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("advertise_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdvertiseMode { get; set; }

    /// <summary>
    /// User-specified list of prefix groups to advertise in custom mode.
    /// This field can only be populated if advertiseMode is CUSTOM and
    /// is advertised to all peers of the router. These groups will be
    /// advertised in addition to any specified prefixes. Leave this field
    /// blank to advertise no custom groups.
    /// 
    /// This enum field has the one valid value: ALL_SUBNETS
    /// </summary>
    [TerraformPropertyName("advertised_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdvertisedGroups { get; set; }

    /// <summary>
    /// Local BGP Autonomous System Number (ASN). Must be an RFC6996
    /// private ASN, either 16-bit or 32-bit. The value will be fixed for
    /// this router resource. All VPN tunnels that link to this router
    /// will have the same local ASN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    [TerraformPropertyName("asn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Asn { get; set; }

    /// <summary>
    /// Explicitly specifies a range of valid BGP Identifiers for this Router.
    /// It is provided as a link-local IPv4 range (from 169.254.0.0/16), of
    /// size at least /30, even if the BGP sessions are over IPv6. It must
    /// not overlap with any IPv4 BGP session ranges. Other vendors commonly
    /// call this router ID.
    /// </summary>
    [TerraformPropertyName("identifier_range")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentifierRange { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "identifier_range");

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
    [TerraformPropertyName("keepalive_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? KeepaliveInterval { get; set; }

}

/// <summary>
/// Block type for md5_authentication_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterMd5AuthenticationKeysBlock : ITerraformBlock
{
    /// <summary>
    /// Value of the key used for MD5 authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// Name used to identify the key. Must be unique within a router.
    /// Must be referenced by exactly one bgpPeer. Must comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterParamsBlock : ITerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the router. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_router resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouter : TerraformResource
{
    public GoogleComputeRouter(string name) : base("google_compute_router", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Indicates if a router is dedicated for use with encrypted VLAN
    /// attachments (interconnectAttachments).
    /// </summary>
    [TerraformPropertyName("encrypted_interconnect_router")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptedInterconnectRouter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// A reference to the network to which this router belongs.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region where the router resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for bgp.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bgp block(s) allowed")]
    [TerraformPropertyName("bgp")]
    public TerraformList<TerraformBlock<GoogleComputeRouterBgpBlock>>? Bgp { get; set; } = new();

    /// <summary>
    /// Block for md5_authentication_keys.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Md5AuthenticationKeys block(s) allowed")]
    [TerraformPropertyName("md5_authentication_keys")]
    public TerraformList<TerraformBlock<GoogleComputeRouterMd5AuthenticationKeysBlock>>? Md5AuthenticationKeys { get; set; } = new();

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeRouterParamsBlock>>? Params { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRouterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
