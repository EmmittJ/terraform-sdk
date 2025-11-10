using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matcher in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEndpointPolicyTimeoutsBlock : TerraformBlock
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
/// Block type for traffic_port_selector in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyTrafficPortSelectorBlock : TerraformBlock
{
    /// <summary>
    /// List of ports. Can be port numbers or port range (example, [80-90] specifies all ports from 80 to 90, including 80 and 90) or named ports or * to specify all ports. If the list is empty, all ports are selected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    public List<TerraformProperty<string>>? Ports
    {
        set => SetProperty("ports", value);
    }

}

/// <summary>
/// Manages a google_network_services_endpoint_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesEndpointPolicy : TerraformResource
{
    public GoogleNetworkServicesEndpointPolicy(string name) : base("google_network_services_endpoint_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("authorization_policy");
        SetOutput("client_tls_policy");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("server_tls_policy");
        SetOutput("type");
    }

    /// <summary>
    /// This field specifies the URL of AuthorizationPolicy resource that applies authorization policies to the inbound traffic at the matched endpoints.
    /// </summary>
    public TerraformProperty<string> AuthorizationPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_policy");
        set => SetProperty("authorization_policy", value);
    }

    /// <summary>
    /// A URL referring to a ClientTlsPolicy resource. ClientTlsPolicy can be set to specify the authentication for traffic from the proxy to the actual endpoints.
    /// </summary>
    public TerraformProperty<string> ClientTlsPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_tls_policy");
        set => SetProperty("client_tls_policy", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// Set of label tags associated with the TcpRoute resource.
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
    /// Name of the EndpointPolicy resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// A URL referring to ServerTlsPolicy resource. ServerTlsPolicy is used to determine the authentication policy to be applied to terminate the inbound traffic at the identified backends.
    /// </summary>
    public TerraformProperty<string> ServerTlsPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_tls_policy");
        set => SetProperty("server_tls_policy", value);
    }

    /// <summary>
    /// The type of endpoint policy. This is primarily used to validate the configuration. Possible values: [&amp;quot;SIDECAR_PROXY&amp;quot;, &amp;quot;GRPC_SERVER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for endpoint_matcher.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointMatcher is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndpointMatcher block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointMatcher block(s) allowed")]
    public List<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock>? EndpointMatcher
    {
        set => SetProperty("endpoint_matcher", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesEndpointPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_port_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficPortSelector block(s) allowed")]
    public List<GoogleNetworkServicesEndpointPolicyTrafficPortSelectorBlock>? TrafficPortSelector
    {
        set => SetProperty("traffic_port_selector", value);
    }

    /// <summary>
    /// Time the TcpRoute was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the TcpRoute was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
