using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_region_network_endpoint resource.
/// </summary>
public class GoogleComputeRegionNetworkEndpoint : TerraformResource
{
    public GoogleComputeRegionNetworkEndpoint(string name) : base("google_compute_region_network_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("network_endpoint_id");
        SetOutput("fqdn");
        SetOutput("id");
        SetOutput("ip_address");
        SetOutput("port");
        SetOutput("project");
        SetOutput("region");
        SetOutput("region_network_endpoint_group");
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    public TerraformProperty<string> Fqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fqdn");
        set => SetProperty("fqdn", value);
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
    /// IPv4 address external endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_IP_PORT.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// Port number of network endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
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
    /// Region where the containing network endpoint group is located.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionNetworkEndpointGroup is required")]
    public required TerraformProperty<string> RegionNetworkEndpointGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region_network_endpoint_group");
        set => SetProperty("region_network_endpoint_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionNetworkEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression NetworkEndpointId => this["network_endpoint_id"];

}
