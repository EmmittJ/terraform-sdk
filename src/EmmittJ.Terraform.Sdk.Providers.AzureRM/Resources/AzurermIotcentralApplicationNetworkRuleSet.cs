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
    public TerraformProperty<bool>? ApplyToDevice
    {
        get => GetProperty<TerraformProperty<bool>>("apply_to_device");
        set => this.WithProperty("apply_to_device", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => this.WithProperty("default_action", value);
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    public TerraformProperty<string>? IotcentralApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("iotcentral_application_id");
        set => this.WithProperty("iotcentral_application_id", value);
    }

}
