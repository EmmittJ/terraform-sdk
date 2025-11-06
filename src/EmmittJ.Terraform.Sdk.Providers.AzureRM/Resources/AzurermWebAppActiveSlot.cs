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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The swap action should overwrite the Production slot&#39;s network configuration with the configuration from this slot. Defaults to `true`.
    /// </summary>
    public bool? OverwriteNetworkConfig
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("overwrite_network_config")?.Value;
        set => this.WithProperty("overwrite_network_config", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID of the Slot to swap with `Production`.
    /// </summary>
    public string? SlotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slot_id")?.Value;
        set => this.WithProperty("slot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timestamp of the last successful swap with `Production`
    /// </summary>
    public TerraformExpression LastSuccessfulSwap => this["last_successful_swap"];

}
