using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for collector_ilb in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringCollectorIlbBlock : ITerraformBlock
{
    /// <summary>
    /// The URL of the forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringFilterBlock : ITerraformBlock
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    [TerraformPropertyName("cidr_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CidrRanges { get; set; }

    /// <summary>
    /// Direction of traffic to mirror. Default value: &amp;quot;BOTH&amp;quot; Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;, &amp;quot;BOTH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("direction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Direction { get; set; }

    /// <summary>
    /// Possible IP protocols including tcp, udp, icmp and esp
    /// </summary>
    [TerraformPropertyName("ip_protocols")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IpProtocols { get; set; }

}

/// <summary>
/// Block type for mirrored_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringMirroredResourcesBlock : ITerraformBlock
{
    /// <summary>
    /// All instances with these tags will be mirrored.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Tags { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringNetworkBlock : ITerraformBlock
{
    /// <summary>
    /// The full self_link URL of the network where this rule is active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePacketMirroringTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_packet_mirroring resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputePacketMirroring : TerraformResource
{
    public GoogleComputePacketMirroring(string name) : base("google_compute_packet_mirroring", name)
    {
    }

    /// <summary>
    /// A human-readable description of the rule.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the packet mirroring rule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Priority { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for collector_ilb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectorIlb is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CollectorIlb block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CollectorIlb block(s) allowed")]
    [TerraformPropertyName("collector_ilb")]
    public TerraformList<TerraformBlock<GoogleComputePacketMirroringCollectorIlbBlock>>? CollectorIlb { get; set; } = new();

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<GoogleComputePacketMirroringFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for mirrored_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroredResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MirroredResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MirroredResources block(s) allowed")]
    [TerraformPropertyName("mirrored_resources")]
    public TerraformList<TerraformBlock<GoogleComputePacketMirroringMirroredResourcesBlock>>? MirroredResources { get; set; } = new();

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Network block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformPropertyName("network")]
    public TerraformList<TerraformBlock<GoogleComputePacketMirroringNetworkBlock>>? Network { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputePacketMirroringTimeoutsBlock>? Timeouts { get; set; } = new();

}
