using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkEndpointGroupTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_network_endpoint_group resource.
/// </summary>
public class GoogleComputeNetworkEndpointGroup : TerraformResource
{
    public GoogleComputeNetworkEndpointGroup(string name) : base("google_compute_network_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("generated_id");
        SetOutput("self_link");
        SetOutput("size");
        SetOutput("default_port");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network");
        SetOutput("network_endpoint_type");
        SetOutput("project");
        SetOutput("subnetwork");
        SetOutput("zone");
    }

    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    public TerraformProperty<double> DefaultPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_port");
        set => SetProperty("default_port", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network to which all network endpoints in the NEG belong.
    /// Uses &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group.
    /// NON_GCP_PRIVATE_IP_PORT is used for hybrid connectivity network
    /// endpoint groups (see https://cloud.google.com/load-balancing/docs/hybrid).
    /// Note that NON_GCP_PRIVATE_IP_PORT can only be used with Backend Services
    /// that 1) have the following load balancing schemes: EXTERNAL, EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED, and INTERNAL_SELF_MANAGED and 2) support the RATE or
    /// CONNECTION balancing modes.
    /// 
    /// Possible values include: GCE_VM_IP, GCE_VM_IP_PORT, NON_GCP_PRIVATE_IP_PORT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, SERVERLESS, and PRIVATE_SERVICE_CONNECT. Default value: &amp;quot;GCE_VM_IP_PORT&amp;quot; Possible values: [&amp;quot;GCE_VM_IP&amp;quot;, &amp;quot;GCE_VM_IP_PORT&amp;quot;, &amp;quot;NON_GCP_PRIVATE_IP_PORT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    public TerraformProperty<string> NetworkEndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_endpoint_type");
        set => SetProperty("network_endpoint_type", value);
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
    /// Optional subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformProperty<string> Subnetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnetwork");
        set => SetProperty("subnetwork", value);
    }

    /// <summary>
    /// Zone where the network endpoint group is located.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkEndpointGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The uniquely generated identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression GeneratedId => this["generated_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Number of network endpoints in the network endpoint group.
    /// </summary>
    public TerraformExpression Size => this["size"];

}
