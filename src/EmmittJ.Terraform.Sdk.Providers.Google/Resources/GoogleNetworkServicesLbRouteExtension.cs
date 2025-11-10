using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for extension_chains in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock : TerraformBlock
{
    /// <summary>
    /// The name for this extension chain. The name is logged as part of the HTTP request logs.
    /// The name must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens,
    /// and can have a maximum length of 63 characters. Additionally, the first character must be a letter
    /// and the last character must be a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_lb_route_extension resource.
/// </summary>
public class GoogleNetworkServicesLbRouteExtension : TerraformResource
{
    public GoogleNetworkServicesLbRouteExtension(string name) : base("google_network_services_lb_route_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A list of references to the forwarding rules to which this service extension is attached to.
    /// At least one forwarding rule is required. There can be only one LbRouteExtension resource per forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRules is required")]
    public List<TerraformProperty<string>>? ForwardingRules
    {
        get => GetProperty<List<TerraformProperty<string>>>("forwarding_rules");
        set => this.WithProperty("forwarding_rules", value);
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
    /// Set of labels associated with the LbRouteExtension resource.
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
    /// All backend services and forwarding rules referenced by this extension must share the same load balancing scheme.
    /// For more information, refer to [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service) and
    /// [Supported application load balancers](https://cloud.google.com/service-extensions/docs/callouts-overview#supported-lbs). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformProperty<string> LoadBalancingScheme
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_scheme");
        set => this.WithProperty("load_balancing_scheme", value);
    }

    /// <summary>
    /// The location of the route extension
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the LbRouteExtension resource in the following format: projects/{project}/locations/{location}/lbRouteExtensions/{lbRouteExtension}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for extension_chains.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExtensionChains block(s) required")]
    public List<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock>? ExtensionChains
    {
        get => GetProperty<List<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock>>("extension_chains");
        set => this.WithProperty("extension_chains", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesLbRouteExtensionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesLbRouteExtensionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
