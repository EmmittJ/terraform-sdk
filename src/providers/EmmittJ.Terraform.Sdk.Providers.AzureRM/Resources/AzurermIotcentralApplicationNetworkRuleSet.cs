using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformProperty<string> IpMask
    {
        set => SetProperty("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock : TerraformBlock
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
        SetOutput("apply_to_device");
        SetOutput("default_action");
        SetOutput("id");
        SetOutput("iotcentral_application_id");
    }

    /// <summary>
    /// The apply_to_device attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyToDevice
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_to_device");
        set => SetProperty("apply_to_device", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string> DefaultAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_action");
        set => SetProperty("default_action", value);
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    public required TerraformProperty<string> IotcentralApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iotcentral_application_id");
        set => SetProperty("iotcentral_application_id", value);
    }

    /// <summary>
    /// Block for ip_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock>? IpRule
    {
        set => SetProperty("ip_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
