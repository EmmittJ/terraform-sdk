using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_app_active_slot resource.
/// </summary>
public class AzurermWebAppActiveSlot : TerraformResource
{
    public AzurermWebAppActiveSlot(string name) : base("azurerm_web_app_active_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("last_successful_swap");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    public TerraformProperty<bool>? OverwriteNetworkConfig
    {
        get => GetProperty<TerraformProperty<bool>>("overwrite_network_config");
        set => this.WithProperty("overwrite_network_config", value);
    }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    public TerraformProperty<string>? SlotId
    {
        get => GetProperty<TerraformProperty<string>>("slot_id");
        set => this.WithProperty("slot_id", value);
    }

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    public TerraformExpression LastSuccessfulSwap => this["last_successful_swap"];

}
