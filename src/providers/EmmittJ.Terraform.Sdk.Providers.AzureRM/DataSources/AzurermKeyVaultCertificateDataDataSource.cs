using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate_data.
/// </summary>
public partial class AzurermKeyVaultCertificateDataDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataDataSource(string name) : base("azurerm_key_vault_certificate_data", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificates_count attribute.
    /// </summary>
    [TerraformProperty("certificates_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CertificatesCount { get; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformProperty("expires")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Expires { get; }

    /// <summary>
    /// The hex attribute.
    /// </summary>
    [TerraformProperty("hex")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hex { get; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Key { get; }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformProperty("not_before")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotBefore { get; }

    /// <summary>
    /// The pem attribute.
    /// </summary>
    [TerraformProperty("pem")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Pem { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
