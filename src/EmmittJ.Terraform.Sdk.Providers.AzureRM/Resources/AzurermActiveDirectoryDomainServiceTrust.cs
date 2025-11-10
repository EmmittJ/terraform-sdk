using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    public required TerraformProperty<string> DomainServiceId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainDnsIps is required")]
    public List<TerraformProperty<string>>? TrustedDomainDnsIps
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_domain_dns_ips");
        set => this.WithProperty("trusted_domain_dns_ips", value);
    }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainFqdn is required")]
    public required TerraformProperty<string> TrustedDomainFqdn
    {
        get => GetProperty<TerraformProperty<string>>("trusted_domain_fqdn");
        set => this.WithProperty("trusted_domain_fqdn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
