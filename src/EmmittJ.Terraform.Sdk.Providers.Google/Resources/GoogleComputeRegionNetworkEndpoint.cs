using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("network_endpoint_id");
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        get => GetProperty<TerraformProperty<string>>("fqdn");
        set => this.WithProperty("fqdn", value);
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
    /// IPv4 address external endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_IP_PORT.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// Port number of network endpoint.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
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
    /// Region where the containing network endpoint group is located.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The network endpoint group this endpoint is part of.
    /// </summary>
    public TerraformProperty<string>? RegionNetworkEndpointGroup
    {
        get => GetProperty<TerraformProperty<string>>("region_network_endpoint_group");
        set => this.WithProperty("region_network_endpoint_group", value);
    }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression NetworkEndpointId => this["network_endpoint_id"];

}
