using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppActiveSlotTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_function_app_active_slot resource.
/// </summary>
public partial class AzurermFunctionAppActiveSlot : TerraformResource
{
    public AzurermFunctionAppActiveSlot(string name) : base("azurerm_function_app_active_slot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    [TerraformProperty("overwrite_network_config")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OverwriteNetworkConfig { get; set; }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformProperty("slot_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SlotId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermFunctionAppActiveSlotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    [TerraformProperty("last_successful_swap")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastSuccessfulSwap { get; }

}
