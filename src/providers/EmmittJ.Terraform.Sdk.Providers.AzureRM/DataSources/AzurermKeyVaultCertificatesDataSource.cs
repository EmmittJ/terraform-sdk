using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificatesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificates.
/// </summary>
public partial class AzurermKeyVaultCertificatesDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificatesDataSource(string name) : base("azurerm_key_vault_certificates", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_pending attribute.
    /// </summary>
    [TerraformProperty("include_pending")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludePending { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificatesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformProperty("certificates")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Certificates { get; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Names { get; }

}
