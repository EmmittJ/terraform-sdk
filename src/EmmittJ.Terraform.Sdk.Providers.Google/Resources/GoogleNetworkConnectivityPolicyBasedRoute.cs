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
        get => GetProperty<TerraformProperty<string>>("dest_range");
        set => WithProperty("dest_range", value);
    }

    /// <summary>
    /// The IP protocol that this policy-based route applies to. Valid values are &#39;TCP&#39;, &#39;UDP&#39;, and &#39;ALL&#39;. Default is &#39;ALL&#39;.
    /// </summary>
    public TerraformProperty<string>? IpProtocol
    {
        get => GetProperty<TerraformProperty<string>>("ip_protocol");
        set => WithProperty("ip_protocol", value);
    }

    /// <summary>
    /// Internet protocol versions this policy-based route applies to. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolVersion is required")]
    public required TerraformProperty<string> ProtocolVersion
    {
        get => GetProperty<TerraformProperty<string>>("protocol_version");
        set => WithProperty("protocol_version", value);
    }

    /// <summary>
    /// The source IP range of outgoing packets that this policy-based route applies to. Default is &amp;quot;0.0.0.0/0&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? SrcRange
    {
        get => GetProperty<TerraformProperty<string>>("src_range");
        set => WithProperty("src_range", value);
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
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

}

/// <summary>
/// Manages a google_network_connectivity_policy_based_route resource.
/// </summary>
public class GoogleNetworkConnectivityPolicyBasedRoute : TerraformResource
{
    public GoogleNetworkConnectivityPolicyBasedRoute(string name) : base("google_network_connectivity_policy_based_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("kind");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
        this.DeclareOutput("warnings");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The IP address of a global-access-enabled L4 ILB that is the next hop for matching packets.
    /// </summary>
    public TerraformProperty<string>? NextHopIlbIp
    {
        get => GetProperty<TerraformProperty<string>>("next_hop_ilb_ip");
        set => this.WithProperty("next_hop_ilb_ip", value);
    }

    /// <summary>
    /// Other routes that will be referenced to determine the next hop of the packet. Possible values: [&amp;quot;DEFAULT_ROUTING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NextHopOtherRoutes
    {
        get => GetProperty<TerraformProperty<string>>("next_hop_other_routes");
        set => this.WithProperty("next_hop_other_routes", value);
    }

    /// <summary>
    /// The priority of this policy-based route. Priority is used to break ties in cases where there are more than one matching policy-based routes found. In cases where multiple policy-based routes are matched, the one with the lowest-numbered priority value wins. The default value is 1000. The priority value must be from 1 to 65535, inclusive.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
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
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock>? Filter
    {
        get => GetProperty<List<GoogleNetworkConnectivityPolicyBasedRouteFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for interconnect_attachment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InterconnectAttachment block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock>? InterconnectAttachment
    {
        get => GetProperty<List<GoogleNetworkConnectivityPolicyBasedRouteInterconnectAttachmentBlock>>("interconnect_attachment");
        set => this.WithProperty("interconnect_attachment", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkConnectivityPolicyBasedRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public List<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock>? VirtualMachine
    {
        get => GetProperty<List<GoogleNetworkConnectivityPolicyBasedRouteVirtualMachineBlock>>("virtual_machine");
        set => this.WithProperty("virtual_machine", value);
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
