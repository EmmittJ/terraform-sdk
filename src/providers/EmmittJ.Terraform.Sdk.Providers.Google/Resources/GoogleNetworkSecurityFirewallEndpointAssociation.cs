using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityFirewallEndpointAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityFirewallEndpointAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_firewall_endpoint_association Terraform resource.
/// Manages a google_network_security_firewall_endpoint_association resource.
/// </summary>
public partial class GoogleNetworkSecurityFirewallEndpointAssociation(string name) : TerraformResource("google_network_security_firewall_endpoint_association", name)
{
    /// <summary>
    /// Whether the association is disabled. True indicates that traffic will not be intercepted.
    /// 
    /// ~&amp;gt; **Note:** The API will reject the request if this value is set to true when creating the resource,
    /// otherwise on an update the association can be disabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The URL of the firewall endpoint that is being associated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallEndpoint is required")]
    public required TerraformValue<string> FirewallEndpoint
    {
        get => new TerraformReference<string>(this, "firewall_endpoint");
        set => SetArgument("firewall_endpoint", value);
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
    /// A map of key/value label pairs to assign to the resource.
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
    /// The location (zone) of the firewall endpoint association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the firewall endpoint association resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The URL of the network that is being associated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The name of the parent this firewall endpoint association belongs to.
    /// Format: projects/{project_id}.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The URL of the TlsInspectionPolicy that is being associated.
    /// </summary>
    public TerraformValue<string>? TlsInspectionPolicy
    {
        get => new TerraformReference<string>(this, "tls_inspection_policy");
        set => SetArgument("tls_inspection_policy", value);
    }

    /// <summary>
    /// Time the firewall endpoint was created in UTC.
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
    /// Whether reconciling is in progress, recommended per https://google.aip.dev/128.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The current state of the endpoint.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
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
    /// Time the firewall endpoint was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityFirewallEndpointAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityFirewallEndpointAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
