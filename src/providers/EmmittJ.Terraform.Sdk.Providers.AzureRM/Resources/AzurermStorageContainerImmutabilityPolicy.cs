using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_storage_container_immutability_policy resource.
/// </summary>
public class AzurermStorageContainerImmutabilityPolicy : TerraformResource
{
    public AzurermStorageContainerImmutabilityPolicy(string name) : base("azurerm_storage_container_immutability_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    [TerraformPropertyName("immutability_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ImmutabilityPeriodInDays { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformPropertyName("locked")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Locked { get; set; }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    [TerraformPropertyName("protected_append_writes_all_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProtectedAppendWritesAllEnabled { get; set; }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("protected_append_writes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProtectedAppendWritesEnabled { get; set; }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    [TerraformPropertyName("storage_container_resource_manager_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageContainerResourceManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageContainerImmutabilityPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
