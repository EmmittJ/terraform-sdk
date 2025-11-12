using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_active_directory_domain_service_trust resource.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceTrust : TerraformResource
{
    public AzurermActiveDirectoryDomainServiceTrust(string name) : base("azurerm_active_directory_domain_service_trust", name)
    {
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    [TerraformProperty("domain_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainServiceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The trusted_domain_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainDnsIps is required")]
    [TerraformProperty("trusted_domain_dns_ips")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? TrustedDomainDnsIps { get; set; }

    /// <summary>
    /// The trusted_domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedDomainFqdn is required")]
    [TerraformProperty("trusted_domain_fqdn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrustedDomainFqdn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermActiveDirectoryDomainServiceTrustTimeoutsBlock Timeouts { get; set; } = new();

}
