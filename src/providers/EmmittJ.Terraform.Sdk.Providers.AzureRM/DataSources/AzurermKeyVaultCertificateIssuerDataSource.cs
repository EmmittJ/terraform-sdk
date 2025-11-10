using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate_issuer.
/// </summary>
public class AzurermKeyVaultCertificateIssuerDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateIssuerDataSource(string name) : base("azurerm_key_vault_certificate_issuer", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The admin attribute.
    /// </summary>
    [TerraformPropertyName("admin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Admin => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "admin");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrgId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "org_id");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProviderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_name");

}
