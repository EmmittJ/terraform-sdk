using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("parent");
    }

    /// <summary>
    /// The DNS domain name suffix of the peered DNS domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsSuffix is required")]
    public required TerraformProperty<string> DnsSuffix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dns_suffix");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Network in the consumer project to peer with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleServiceNetworkingPeeredDnsDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public TerraformExpression Parent => this["parent"];

}
