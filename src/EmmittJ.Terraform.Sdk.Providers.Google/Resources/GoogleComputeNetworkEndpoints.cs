using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    /// The network endpoint group these endpoints are part of.
    /// </summary>
    public TerraformProperty<string>? NetworkEndpointGroup
    {
        get => GetProperty<TerraformProperty<string>>("network_endpoint_group");
        set => this.WithProperty("network_endpoint_group", value);
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
    /// Zone where the containing network endpoint group is located.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}
