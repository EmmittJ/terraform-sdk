using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_networking_peered_dns_domain resource.
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomain : TerraformResource
{
    public GoogleServiceNetworkingPeeredDnsDomain(string name) : base("google_service_networking_peered_dns_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("parent");
    }

    /// <summary>
    /// The DNS domain name suffix of the peered DNS domain.
    /// </summary>
    public TerraformProperty<string>? DnsSuffix
    {
        get => GetProperty<TerraformProperty<string>>("dns_suffix");
        set => this.WithProperty("dns_suffix", value);
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
    /// Name of the peered DNS domain.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Network in the consumer project to peer with.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the service to create a peered DNS domain for, e.g. servicenetworking.googleapis.com
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformExpression Parent => this["parent"];

}
