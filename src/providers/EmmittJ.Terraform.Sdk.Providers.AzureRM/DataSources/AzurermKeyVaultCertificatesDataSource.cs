using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificatesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificates.
/// </summary>
public class AzurermKeyVaultCertificatesDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificatesDataSource(string name) : base("azurerm_key_vault_certificates", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_pending attribute.
    /// </summary>
    [TerraformPropertyName("include_pending")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePending { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificatesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformPropertyName("certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Certificates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificates");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Names => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "names");

}
