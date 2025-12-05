using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for collector_ilb in GoogleComputePacketMirroring.
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringCollectorIlbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collector_ilb";

    /// <summary>
    /// The URL of the forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for filter in GoogleComputePacketMirroring.
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    public TerraformList<string>? CidrRanges
    {
        get => GetArgument<TerraformList<string>>("cidr_ranges");
        set => SetArgument("cidr_ranges", value);
    }

    /// <summary>
    /// Direction of traffic to mirror. Default value: &amp;quot;BOTH&amp;quot; Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;, &amp;quot;BOTH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Direction
    {
        get => GetArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// Possible IP protocols including tcp, udp, icmp and esp
    /// </summary>
    public TerraformList<string>? IpProtocols
    {
        get => GetArgument<TerraformList<string>>("ip_protocols");
        set => SetArgument("ip_protocols", value);
    }

}


/// <summary>
/// Block type for mirrored_resources in GoogleComputePacketMirroring.
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringMirroredResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mirrored_resources";

    /// <summary>
    /// All instances with these tags will be mirrored.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Instances block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputePacketMirroringMirroredResourcesBlockInstancesBlock>? Instances
    {
        get => GetArgument<TerraformSet<GoogleComputePacketMirroringMirroredResourcesBlockInstancesBlock>>("instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// Subnetworks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputePacketMirroringMirroredResourcesBlockSubnetworksBlock>? Subnetworks
    {
        get => GetArgument<TerraformSet<GoogleComputePacketMirroringMirroredResourcesBlockSubnetworksBlock>>("subnetworks");
        set => SetArgument("subnetworks", value);
    }

}

/// <summary>
/// Block type for instances in GoogleComputePacketMirroringMirroredResourcesBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputePacketMirroringMirroredResourcesBlockInstancesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instances";

    /// <summary>
    /// The URL of the instances where this rule should be active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for subnetworks in GoogleComputePacketMirroringMirroredResourcesBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputePacketMirroringMirroredResourcesBlockSubnetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnetworks";

    /// <summary>
    /// The URL of the subnetwork where this rule should be active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for network in GoogleComputePacketMirroring.
/// Nesting mode: list
/// </summary>
public class GoogleComputePacketMirroringNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// The full self_link URL of the network where this rule is active.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputePacketMirroring.
/// Nesting mode: single
/// </summary>
public class GoogleComputePacketMirroringTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_packet_mirroring Terraform resource.
/// Manages a google_compute_packet_mirroring resource.
/// </summary>
public partial class GoogleComputePacketMirroring(string name) : TerraformResource("google_compute_packet_mirroring", name)
{
    /// <summary>
    /// A human-readable description of the rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the packet mirroring rule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority") ?? CreateReference("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// CollectorIlb block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectorIlb is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CollectorIlb block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CollectorIlb block(s) allowed")]
    public required TerraformList<GoogleComputePacketMirroringCollectorIlbBlock> CollectorIlb
    {
        get => GetRequiredArgument<TerraformList<GoogleComputePacketMirroringCollectorIlbBlock>>("collector_ilb");
        set => SetArgument("collector_ilb", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleComputePacketMirroringFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleComputePacketMirroringFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// MirroredResources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroredResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MirroredResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MirroredResources block(s) allowed")]
    public required TerraformList<GoogleComputePacketMirroringMirroredResourcesBlock> MirroredResources
    {
        get => GetRequiredArgument<TerraformList<GoogleComputePacketMirroringMirroredResourcesBlock>>("mirrored_resources");
        set => SetArgument("mirrored_resources", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Network block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public required TerraformList<GoogleComputePacketMirroringNetworkBlock> Network
    {
        get => GetRequiredArgument<TerraformList<GoogleComputePacketMirroringNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputePacketMirroringTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputePacketMirroringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
