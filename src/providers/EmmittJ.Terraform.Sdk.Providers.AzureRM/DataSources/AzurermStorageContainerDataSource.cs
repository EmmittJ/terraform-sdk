using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_container.
/// </summary>
public class AzurermStorageContainerDataSource : TerraformDataSource
{
    public AzurermStorageContainerDataSource(string name) : base("azurerm_storage_container", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageContainerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    [TerraformPropertyName("container_access_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerAccessType => new TerraformReference(this, "container_access_type");

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("default_encryption_scope")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultEncryptionScope => new TerraformReference(this, "default_encryption_scope");

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_scope_override_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EncryptionScopeOverrideEnabled => new TerraformReference(this, "encryption_scope_override_enabled");

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    [TerraformPropertyName("has_immutability_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasImmutabilityPolicy => new TerraformReference(this, "has_immutability_policy");

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    [TerraformPropertyName("has_legal_hold")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasLegalHold => new TerraformReference(this, "has_legal_hold");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceManagerId => new TerraformReference(this, "resource_manager_id");

}
