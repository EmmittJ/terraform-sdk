using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for collector_ilb in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringCollectorIlbBlock : TerraformBlock
{
    /// <summary>
    /// The URL of the forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringFilterBlock : TerraformBlock
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    public List<TerraformProperty<string>>? CidrRanges
    {
        set => SetProperty("cidr_ranges", value);
    }

    /// <summary>
    /// Direction of traffic to mirror. Default value: &amp;quot;BOTH&amp;quot; Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;, &amp;quot;BOTH&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        set => SetProperty("direction", value);
    }

    /// <summary>
    /// Possible IP protocols including tcp, udp, icmp and esp
    /// </summary>
    public List<TerraformProperty<string>>? IpProtocols
    {
        set => SetProperty("ip_protocols", value);
    }

}

/// <summary>
/// Block type for mirrored_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringMirroredResourcesBlock : TerraformBlock
{
    /// <summary>
    /// All instances with these tags will be mirrored.
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringNetworkBlock : TerraformBlock
{
    /// <summary>
    /// The full self_link URL of the network where this rule is active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePacketMirroringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_packet_mirroring resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputePacketMirroring : TerraformResource
{
    public GoogleComputePacketMirroring(string name) : base("google_compute_packet_mirroring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// A human-readable description of the rule.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the packet mirroring rule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for collector_ilb.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectorIlb is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CollectorIlb block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CollectorIlb block(s) allowed")]
    public List<GoogleComputePacketMirroringCollectorIlbBlock>? CollectorIlb
    {
        set => SetProperty("collector_ilb", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<GoogleComputePacketMirroringFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for mirrored_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroredResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MirroredResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MirroredResources block(s) allowed")]
    public List<GoogleComputePacketMirroringMirroredResourcesBlock>? MirroredResources
    {
        set => SetProperty("mirrored_resources", value);
    }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Network block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public List<GoogleComputePacketMirroringNetworkBlock>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputePacketMirroringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
