using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_endpoints in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeNetworkEndpointsNetworkEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// The name for a specific VM instance that the IP address belongs to.
    /// This is required for network endpoints of type GCE_VM_IP_PORT.
    /// The instance must be in the same zone as the network endpoint group.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// IPv4 address of network endpoint. The IP address must belong
    /// to a VM in GCE (either the primary IP or as part of an aliased IP
    /// range).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformProperty<string> IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// Port number of network endpoint.
    /// **Note** &#39;port&#39; is required unless the Network Endpoint Group is created
    /// with the type of &#39;GCE_VM_IP&#39;
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkEndpointsTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_network_endpoints resource.
/// </summary>
public class GoogleComputeNetworkEndpoints : TerraformResource
{
    public GoogleComputeNetworkEndpoints(string name) : base("google_compute_network_endpoints", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("network_endpoint_group");
        SetOutput("project");
        SetOutput("zone");
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
    /// The network endpoint group these endpoints are part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkEndpointGroup is required")]
    public required TerraformProperty<string> NetworkEndpointGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_endpoint_group");
        set => SetProperty("network_endpoint_group", value);
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
    /// Zone where the containing network endpoint group is located.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for network_endpoints.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeNetworkEndpointsNetworkEndpointsBlock>? NetworkEndpoints
    {
        set => SetProperty("network_endpoints", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkEndpointsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
