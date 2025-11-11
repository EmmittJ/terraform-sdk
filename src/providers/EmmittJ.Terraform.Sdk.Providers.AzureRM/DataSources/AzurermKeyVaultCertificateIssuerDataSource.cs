using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate_issuer.
/// </summary>
public partial class AzurermKeyVaultCertificateIssuerDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateIssuerDataSource(string name) : base("azurerm_key_vault_certificate_issuer", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountId { get; }

    /// <summary>
    /// The admin attribute.
    /// </summary>
    [TerraformProperty("admin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Admin { get; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformProperty("org_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrgId { get; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProviderName { get; }

}
