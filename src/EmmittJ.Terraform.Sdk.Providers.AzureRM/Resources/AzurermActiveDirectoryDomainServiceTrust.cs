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
    public string? DomainServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_service_id")?.Value;
        set => this.WithProperty("domain_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    public List<string>? TrustedDomainDnsIps
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("trusted_domain_dns_ips")?.Value;
        set => this.WithProperty("trusted_domain_dns_ips", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    public string? TrustedDomainFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trusted_domain_fqdn")?.Value;
        set => this.WithProperty("trusted_domain_fqdn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
