using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppActiveSlotTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_function_app_active_slot resource.
/// </summary>
public class AzurermFunctionAppActiveSlot : TerraformResource
{
    public AzurermFunctionAppActiveSlot(string name) : base("azurerm_function_app_active_slot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    [TerraformPropertyName("overwrite_network_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OverwriteNetworkConfig { get; set; }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformPropertyName("slot_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SlotId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppActiveSlotTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    [TerraformPropertyName("last_successful_swap")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastSuccessfulSwap => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_successful_swap");

}
