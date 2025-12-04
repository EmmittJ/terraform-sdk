using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebAppActiveSlot.
/// Nesting mode: single
/// </summary>
public class AzurermWebAppActiveSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_web_app_active_slot Terraform resource.
/// Manages a azurerm_web_app_active_slot resource.
/// </summary>
public partial class AzurermWebAppActiveSlot(string name) : TerraformResource("azurerm_web_app_active_slot", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    public TerraformValue<bool>? OverwriteNetworkConfig
    {
        get => GetArgument<TerraformValue<bool>>("overwrite_network_config");
        set => SetArgument("overwrite_network_config", value);
    }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformValue<string> SlotId
    {
        get => GetArgument<TerraformValue<string>>("slot_id");
        set => SetArgument("slot_id", value);
    }

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    public TerraformValue<string> LastSuccessfulSwap
        => AsReference("last_successful_swap");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebAppActiveSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebAppActiveSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
