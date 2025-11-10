using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? ContainerAccessType { get; set; }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("default_encryption_scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultEncryptionScope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_encryption_scope");

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_scope_override_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptionScopeOverrideEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("storage_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageContainerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    [TerraformPropertyName("has_immutability_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasImmutabilityPolicy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_immutability_policy");

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    [TerraformPropertyName("has_legal_hold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasLegalHold => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_legal_hold");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_id");

}
