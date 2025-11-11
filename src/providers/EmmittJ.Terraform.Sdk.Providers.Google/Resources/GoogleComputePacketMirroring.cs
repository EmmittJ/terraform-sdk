using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for collector_ilb in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputePacketMirroringCollectorIlbBlock : TerraformBlockBase
{
    /// <summary>
    /// The URL of the forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputePacketMirroringFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    [TerraformProperty("cidr_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CidrRanges { get; set; }

    /// <summary>
    /// Direction of traffic to mirror. Default value: &amp;quot;BOTH&amp;quot; Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;, &amp;quot;BOTH&amp;quot;]
    /// </summary>
    [TerraformProperty("direction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Direction { get; set; }

    /// <summary>
    /// Possible IP protocols including tcp, udp, icmp and esp
    /// </summary>
    [TerraformProperty("ip_protocols")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IpProtocols { get; set; }

}

/// <summary>
/// Block type for mirrored_resources in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputePacketMirroringMirroredResourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// All instances with these tags will be mirrored.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputePacketMirroringNetworkBlock : TerraformBlockBase
{
    /// <summary>
    /// The full self_link URL of the network where this rule is active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputePacketMirroringTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_packet_mirroring resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputePacketMirroring : TerraformResource
{
    public GoogleComputePacketMirroring(string name) : base("google_compute_packet_mirroring", name)
    {
    }

    /// <summary>
    /// A human-readable description of the rule.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the packet mirroring rule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for collector_ilb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectorIlb is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CollectorIlb block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CollectorIlb block(s) allowed")]
    [TerraformProperty("collector_ilb")]
    public partial TerraformList<TerraformBlock<GoogleComputePacketMirroringCollectorIlbBlock>>? CollectorIlb { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public partial TerraformList<TerraformBlock<GoogleComputePacketMirroringFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for mirrored_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroredResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MirroredResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MirroredResources block(s) allowed")]
    [TerraformProperty("mirrored_resources")]
    public partial TerraformList<TerraformBlock<GoogleComputePacketMirroringMirroredResourcesBlock>>? MirroredResources { get; set; }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Network block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformProperty("network")]
    public partial TerraformList<TerraformBlock<GoogleComputePacketMirroringNetworkBlock>>? Network { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputePacketMirroringTimeoutsBlock>? Timeouts { get; set; }

}
