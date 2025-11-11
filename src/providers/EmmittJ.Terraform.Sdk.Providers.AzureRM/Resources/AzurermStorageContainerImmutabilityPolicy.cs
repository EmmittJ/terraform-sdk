using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock
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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    [TerraformPropertyName("immutability_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ImmutabilityPeriodInDays { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformPropertyName("locked")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Locked { get; set; }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    [TerraformPropertyName("protected_append_writes_all_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProtectedAppendWritesAllEnabled { get; set; }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("protected_append_writes_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProtectedAppendWritesEnabled { get; set; }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    [TerraformPropertyName("storage_container_resource_manager_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageContainerResourceManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageContainerImmutabilityPolicyTimeoutsBlock>? Timeouts { get; set; }

}
