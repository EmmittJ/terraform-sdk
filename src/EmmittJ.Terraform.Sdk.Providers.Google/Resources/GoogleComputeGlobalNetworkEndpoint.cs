using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_global_network_endpoint resource.
/// </summary>
public class GoogleComputeGlobalNetworkEndpoint : TerraformResource
{
    public GoogleComputeGlobalNetworkEndpoint(string name) : base("google_compute_global_network_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    public TerraformLiteralProperty<string>? Fqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fqdn");
        set => this.WithProperty("fqdn", value);
    }

    /// <summary>
    /// The global network endpoint group this endpoint is part of.
    /// </summary>
    public TerraformLiteralProperty<string>? GlobalNetworkEndpointGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_endpoint_group");
        set => this.WithProperty("global_network_endpoint_group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// IPv4 address external endpoint.
    /// </summary>
    public TerraformLiteralProperty<string>? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// Port number of the external endpoint.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
