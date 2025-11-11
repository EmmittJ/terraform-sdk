using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_container resource.
/// </summary>
public class AzurermStorageContainer : TerraformResource
{
    public AzurermStorageContainer(string name) : base("azurerm_storage_container", name)
    {
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    [TerraformPropertyName("container_access_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerAccessType { get; set; }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("default_encryption_scope")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultEncryptionScope { get; set; } = default!;

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_scope_override_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionScopeOverrideEnabled { get; set; }

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
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("storage_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageContainerTimeoutsBlock>? Timeouts { get; set; }

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
