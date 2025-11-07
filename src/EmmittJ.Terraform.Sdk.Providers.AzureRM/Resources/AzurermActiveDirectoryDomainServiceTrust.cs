using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_active_directory_domain_service_trust resource.
/// </summary>
public class AzurermActiveDirectoryDomainServiceTrust : TerraformResource
{
    public AzurermActiveDirectoryDomainServiceTrust(string name) : base("azurerm_active_directory_domain_service_trust", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? DomainServiceId
    {
        get => GetProperty<TerraformProperty<string>>("domain_service_id");
        set => this.WithProperty("domain_service_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    public TerraformProperty<List<string>>? TrustedDomainDnsIps
    {
        get => GetProperty<TerraformProperty<List<string>>>("trusted_domain_dns_ips");
        set => this.WithProperty("trusted_domain_dns_ips", value);
    }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedDomainFqdn
    {
        get => GetProperty<TerraformProperty<string>>("trusted_domain_fqdn");
        set => this.WithProperty("trusted_domain_fqdn", value);
    }

}
