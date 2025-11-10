using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultSecretsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_secrets.
/// </summary>
public class AzurermKeyVaultSecretsDataSource : TerraformDataSource
{
    public AzurermKeyVaultSecretsDataSource(string name) : base("azurerm_key_vault_secrets", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultSecretsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Names => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "names");

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    [TerraformPropertyName("secrets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Secrets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secrets");

}
