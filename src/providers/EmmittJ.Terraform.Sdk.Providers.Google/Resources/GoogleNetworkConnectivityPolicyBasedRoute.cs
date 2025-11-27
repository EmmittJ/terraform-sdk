using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in GoogleNetworkConnectivityPolicyBasedRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The destination IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DestRange
    {
        get => new TerraformReference<string>(this, "dest_range");
        set => SetArgument("dest_range", value);
    }

    /// <summary>
    /// The IP protocol that this policy-based route applies to. Valid values are &#39;TCP&#39;, &#39;UDP&#39;, and &#39;ALL&#39;. Default is &#39;ALL&#39;.
    /// </summary>
    public TerraformValue<string>? IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// Internet protocol versions this policy-based route applies to. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolVersion is required")]
    public required TerraformValue<string> ProtocolVersion
    {
        get => new TerraformReference<string>(this, "protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The source IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    public TerraformValue<string>? SrcRange
    {
        get => new TerraformReference<string>(this, "src_range");
        set => SetArgument("src_range", value);
    }

}


/// <summary>
/// Block type for interconnect_attachment in GoogleNetworkConnectivityPolicyBasedRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interconnect_attachment";

    /// <summary>
    /// Cloud region to install this policy-based route on for Interconnect attachments. Use &#39;all&#39; to install it on all Interconnect attachments.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivityPolicyBasedRoute.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_machine in GoogleNetworkConnectivityPolicyBasedRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// A list of VM instance tags that this policy-based route applies to. VM instances that have ANY of tags specified here will install this PBR.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tags is required")]
    public TerraformList<string>? Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Represents a google_network_connectivity_policy_based_route Terraform resource.
/// Manages a google_network_connectivity_policy_based_route resource.
/// </summary>
public partial class GoogleNetworkConnectivityPolicyBasedRoute(string name) : TerraformResource("google_network_connectivity_policy_based_route", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The IP address of a global-access-enabled L4 ILB that is the next hop for matching packets.
    /// </summary>
    public TerraformValue<string>? NextHopIlbIp
    {
        get => new TerraformReference<string>(this, "next_hop_ilb_ip");
        set => SetArgument("next_hop_ilb_ip", value);
    }

    /// <summary>
    /// Other routes that will be referenced to determine the next hop of the packet. Possible values: [&amp;quot;DEFAULT_ROUTING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NextHopOtherRoutes
    {
        get => new TerraformReference<string>(this, "next_hop_other_routes");
        set => SetArgument("next_hop_other_routes", value);
    }

    /// <summary>
    /// The priority of this policy-based route. Priority is used to break ties in cases where there are more than one matching policy-based routes found. In cases where multiple policy-based routes are matched, the one with the lowest-numbered priority value wins. The default value is 1000. The priority value must be from 1 to 65535, inclusive.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
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
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Type of this resource.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    public TerraformList<TerraformMap<object>> Warnings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "warnings").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public required TerraformList<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// InterconnectAttachment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InterconnectAttachment block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock>? InterconnectAttachment
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock>>("interconnect_attachment");
        set => SetArgument("interconnect_attachment", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}
