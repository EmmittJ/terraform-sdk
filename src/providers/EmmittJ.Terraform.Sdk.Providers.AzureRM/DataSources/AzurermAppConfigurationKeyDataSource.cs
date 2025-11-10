using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationKeyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration_key.
/// </summary>
public class AzurermAppConfigurationKeyDataSource : TerraformDataSource
{
    public AzurermAppConfigurationKeyDataSource(string name) : base("azurerm_app_configuration_key", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformPropertyName("configuration_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConfigurationStoreId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Label { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppConfigurationKeyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformPropertyName("locked")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Locked => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "locked");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "value");

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    [TerraformPropertyName("vault_key_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VaultKeyReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vault_key_reference");

}
