using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public TerraformBlock<AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    [TerraformPropertyName("certificate_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CertificatePermissions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "certificate_permissions");

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    [TerraformPropertyName("key_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> KeyPermissions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "key_permissions");

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    [TerraformPropertyName("secret_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SecretPermissions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "secret_permissions");

}
