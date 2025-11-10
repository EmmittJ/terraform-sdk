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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("domain_service_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("trusted_domain_dns_ips");
        SetOutput("trusted_domain_fqdn");
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    public required TerraformProperty<string> DomainServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_service_id");
        set => SetProperty("domain_service_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainDnsIps is required")]
    public List<TerraformProperty<string>> TrustedDomainDnsIps
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("trusted_domain_dns_ips");
        set => SetProperty("trusted_domain_dns_ips", value);
    }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainFqdn is required")]
    public required TerraformProperty<string> TrustedDomainFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trusted_domain_fqdn");
        set => SetProperty("trusted_domain_fqdn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
