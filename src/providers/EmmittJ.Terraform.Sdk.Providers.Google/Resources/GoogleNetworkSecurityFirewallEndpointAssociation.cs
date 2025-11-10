using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityFirewallEndpointAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_firewall_endpoint_association resource.
/// </summary>
public class GoogleNetworkSecurityFirewallEndpointAssociation : TerraformResource
{
    public GoogleNetworkSecurityFirewallEndpointAssociation(string name) : base("google_network_security_firewall_endpoint_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("reconciling");
        SetOutput("self_link");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("disabled");
        SetOutput("firewall_endpoint");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network");
        SetOutput("parent");
        SetOutput("tls_inspection_policy");
    }

    /// <summary>
    /// Whether the association is disabled. True indicates that traffic will not be intercepted.
    /// 
    /// ~&amp;gt; **Note:** The API will reject the request if this value is set to true when creating the resource,
    /// otherwise on an update the association can be disabled.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The URL of the firewall endpoint that is being associated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallEndpoint is required")]
    public required TerraformProperty<string> FirewallEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_endpoint");
        set => SetProperty("firewall_endpoint", value);
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
    /// A map of key/value label pairs to assign to the resource.
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
    /// The location (zone) of the firewall endpoint association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the firewall endpoint association resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The URL of the network that is being associated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The name of the parent this firewall endpoint association belongs to.
    /// Format: projects/{project_id}.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The URL of the TlsInspectionPolicy that is being associated.
    /// </summary>
    public TerraformProperty<string> TlsInspectionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tls_inspection_policy");
        set => SetProperty("tls_inspection_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityFirewallEndpointAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the firewall endpoint was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Whether reconciling is in progress, recommended per https://google.aip.dev/128.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The current state of the endpoint.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the firewall endpoint was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
