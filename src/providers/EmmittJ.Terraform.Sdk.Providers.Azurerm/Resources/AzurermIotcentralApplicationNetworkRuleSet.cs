using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_rule in AzurermIotcentralApplicationNetworkRuleSet.
/// Nesting mode: list
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformValue<string> IpMask
    {
        get => GetArgument<TerraformValue<string>>("ip_mask");
        set => SetArgument("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermIotcentralApplicationNetworkRuleSet.
/// Nesting mode: single
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_iotcentral_application_network_rule_set Terraform resource.
/// Manages a azurerm_iotcentral_application_network_rule_set resource.
/// </summary>
public partial class AzurermIotcentralApplicationNetworkRuleSet(string name) : TerraformResource("azurerm_iotcentral_application_network_rule_set", name)
{
    /// <summary>
    /// The apply_to_device attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyToDevice
    {
        get => GetArgument<TerraformValue<bool>>("apply_to_device");
        set => SetArgument("apply_to_device", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => GetArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    public required TerraformValue<string> IotcentralApplicationId
    {
        get => GetArgument<TerraformValue<string>>("iotcentral_application_id");
        set => SetArgument("iotcentral_application_id", value);
    }

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
