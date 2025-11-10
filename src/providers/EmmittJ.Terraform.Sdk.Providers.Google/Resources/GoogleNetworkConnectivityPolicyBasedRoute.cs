using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteFilterBlock : TerraformBlock
{
    /// <summary>
    /// The destination IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DestRange
    {
        set => SetProperty("dest_range", value);
    }

    /// <summary>
    /// The IP protocol that this policy-based route applies to. Valid values are &#39;TCP&#39;, &#39;UDP&#39;, and &#39;ALL&#39;. Default is &#39;ALL&#39;.
    /// </summary>
    public TerraformProperty<string>? IpProtocol
    {
        set => SetProperty("ip_protocol", value);
    }

    /// <summary>
    /// Internet protocol versions this policy-based route applies to. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolVersion is required")]
    public required TerraformProperty<string> ProtocolVersion
    {
        set => SetProperty("protocol_version", value);
    }

    /// <summary>
    /// The source IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? SrcRange
    {
        set => SetProperty("src_range", value);
    }

}

/// <summary>
/// Block type for interconnect_attachment in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock : TerraformBlock
{
    /// <summary>
    /// Cloud region to install this policy-based route on for Interconnect attachments. Use &#39;all&#39; to install it on all Interconnect attachments.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_machine in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// A list of VM instance tags that this policy-based route applies to. VM instances that have ANY of tags specified here will install this PBR.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tags is required")]
    public List<TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Manages a google_network_connectivity_policy_based_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivityPolicyBasedRoute : TerraformResource
{
    public GoogleNetworkConnectivityPolicyBasedRoute(string name) : base("google_network_connectivity_policy_based_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("kind");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("warnings");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("network");
        SetOutput("next_hop_ilb_ip");
        SetOutput("next_hop_other_routes");
        SetOutput("priority");
        SetOutput("project");
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The IP address of a global-access-enabled L4 ILB that is the next hop for matching packets.
    /// </summary>
    public TerraformProperty<string> NextHopIlbIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_ilb_ip");
        set => SetProperty("next_hop_ilb_ip", value);
    }

    /// <summary>
    /// Other routes that will be referenced to determine the next hop of the packet. Possible values: [&amp;quot;DEFAULT_ROUTING&amp;quot;]
    /// </summary>
    public TerraformProperty<string> NextHopOtherRoutes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_other_routes");
        set => SetProperty("next_hop_other_routes", value);
    }

    /// <summary>
    /// The priority of this policy-based route. Priority is used to break ties in cases where there are more than one matching policy-based routes found. In cases where multiple policy-based routes are matched, the one with the lowest-numbered priority value wins. The default value is 1000. The priority value must be from 1 to 65535, inclusive.
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
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for interconnect_attachment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InterconnectAttachment block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock>? InterconnectAttachment
    {
        set => SetProperty("interconnect_attachment", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock>? VirtualMachine
    {
        set => SetProperty("virtual_machine", value);
    }

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Type of this resource.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time when the policy-based route was created.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    public TerraformExpression Warnings => this["warnings"];

}
