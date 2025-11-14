using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppActiveSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    [TerraformArgument("overwrite_network_config")]
    public TerraformValue<bool>? OverwriteNetworkConfig
    {
        get => new TerraformReference<bool>(this, "overwrite_network_config");
        set => SetArgument("overwrite_network_config", value);
    }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformArgument("slot_id")]
    public required TerraformValue<string> SlotId
    {
        get => new TerraformReference<string>(this, "slot_id");
        set => SetArgument("slot_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFunctionAppActiveSlotTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    [TerraformArgument("last_successful_swap")]
    public TerraformValue<string> LastSuccessfulSwap
    {
        get => new TerraformReference<string>(this, "last_successful_swap");
    }

}
