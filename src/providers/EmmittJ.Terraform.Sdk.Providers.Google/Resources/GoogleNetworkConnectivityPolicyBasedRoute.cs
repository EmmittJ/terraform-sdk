using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivityPolicyBasedRouteFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The destination IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    [TerraformProperty("dest_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestRange { get; set; }

    /// <summary>
    /// The IP protocol that this policy-based route applies to. Valid values are &#39;TCP&#39;, &#39;UDP&#39;, and &#39;ALL&#39;. Default is &#39;ALL&#39;.
    /// </summary>
    [TerraformProperty("ip_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpProtocol { get; set; }

    /// <summary>
    /// Internet protocol versions this policy-based route applies to. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolVersion is required")]
    [TerraformProperty("protocol_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtocolVersion { get; set; }

    /// <summary>
    /// The source IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    [TerraformProperty("src_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SrcRange { get; set; }

}

/// <summary>
/// Block type for interconnect_attachment in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock() : TerraformBlock("interconnect_attachment")
{
    /// <summary>
    /// Cloud region to install this policy-based route on for Interconnect attachments. Use &#39;all&#39; to install it on all Interconnect attachments.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for virtual_machine in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock() : TerraformBlock("virtual_machine")
{
    /// <summary>
    /// A list of VM instance tags that this policy-based route applies to. VM instances that have ANY of tags specified here will install this PBR.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tags is required")]
    [TerraformProperty("tags")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Tags { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_policy_based_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkConnectivityPolicyBasedRoute : TerraformResource
{
    public GoogleNetworkConnectivityPolicyBasedRoute(string name) : base("google_network_connectivity_policy_based_route", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The IP address of a global-access-enabled L4 ILB that is the next hop for matching packets.
    /// </summary>
    [TerraformProperty("next_hop_ilb_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NextHopIlbIp { get; set; }

    /// <summary>
    /// Other routes that will be referenced to determine the next hop of the packet. Possible values: [&amp;quot;DEFAULT_ROUTING&amp;quot;]
    /// </summary>
    [TerraformProperty("next_hop_other_routes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NextHopOtherRoutes { get; set; }

    /// <summary>
    /// The priority of this policy-based route. Priority is used to break ties in cases where there are more than one matching policy-based routes found. In cases where multiple policy-based routes are matched, the one with the lowest-numbered priority value wins. The default value is 1000. The priority value must be from 1 to 65535, inclusive.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public required TerraformList<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for interconnect_attachment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InterconnectAttachment block(s) allowed")]
    [TerraformProperty("interconnect_attachment")]
    public TerraformList<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock> InterconnectAttachment { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    [TerraformProperty("virtual_machine")]
    public TerraformList<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock> VirtualMachine { get; set; } = new();

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Type of this resource.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    [TerraformProperty("warnings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Warnings { get; }

}
