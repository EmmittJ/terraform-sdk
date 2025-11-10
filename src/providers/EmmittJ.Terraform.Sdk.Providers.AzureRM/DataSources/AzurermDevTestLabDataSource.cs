using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestLabDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_test_lab.
/// </summary>
public class AzurermDevTestLabDataSource : TerraformDataSource
{
    public AzurermDevTestLabDataSource(string name) : base("azurerm_dev_test_lab", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDevTestLabDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("artifacts_storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArtifactsStorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "artifacts_storage_account_id");

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("default_premium_storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPremiumStorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_premium_storage_account_id");

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("default_storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultStorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_storage_account_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyVaultId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("premium_data_disk_storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PremiumDataDiskStorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "premium_data_disk_storage_account_id");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformPropertyName("unique_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_identifier");

}
