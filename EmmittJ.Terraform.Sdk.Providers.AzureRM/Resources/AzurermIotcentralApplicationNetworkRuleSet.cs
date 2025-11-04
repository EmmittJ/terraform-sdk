using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iotcentral_application_network_rule_set resource.
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSet : TerraformResource
{
    public AzurermIotcentralApplicationNetworkRuleSet(string name) : base("azurerm_iotcentral_application_network_rule_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The apply_to_device attribute.
    /// </summary>
    public bool? ApplyToDevice
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_to_device")?.Value;
        set => this.WithProperty("apply_to_device", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public string? DefaultAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_action")?.Value;
        set => this.WithProperty("default_action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    public string? IotcentralApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iotcentral_application_id")?.Value;
        set => this.WithProperty("iotcentral_application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
