using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppActiveSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_function_app_active_slot resource.
/// </summary>
public class AzurermFunctionAppActiveSlot : TerraformResource
{
    public AzurermFunctionAppActiveSlot(string name) : base("azurerm_function_app_active_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("last_successful_swap");
        SetOutput("id");
        SetOutput("overwrite_network_config");
        SetOutput("slot_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    public TerraformProperty<bool> OverwriteNetworkConfig
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("overwrite_network_config");
        set => SetProperty("overwrite_network_config", value);
    }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformProperty<string> SlotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("slot_id");
        set => SetProperty("slot_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppActiveSlotTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    public TerraformExpression LastSuccessfulSwap => this["last_successful_swap"];

}
