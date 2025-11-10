using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityFirewallEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_firewall_endpoint resource.
/// </summary>
public class GoogleNetworkSecurityFirewallEndpoint : TerraformResource
{
    public GoogleNetworkSecurityFirewallEndpoint(string name) : base("google_network_security_firewall_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_networks");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("self_link");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Project to bill on endpoint uptime usage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProjectId is required")]
    public required TerraformProperty<string> BillingProjectId
    {
        get => GetProperty<TerraformProperty<string>>("billing_project_id");
        set => this.WithProperty("billing_project_id", value);
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
    /// A map of key/value label pairs to assign to the resource.
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
    /// The location (zone) of the firewall endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the firewall endpoint resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name of the parent this firewall endpoint belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityFirewallEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkSecurityFirewallEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// List of networks that are associated with this endpoint in the local zone.
    /// This is a projection of the FirewallEndpointAssociations pointing at this
    /// endpoint. A network will only appear in this list after traffic routing is
    /// fully configured. Format: projects/{project}/global/networks/{name}.
    /// </summary>
    public TerraformExpression AssociatedNetworks => this["associated_networks"];

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
