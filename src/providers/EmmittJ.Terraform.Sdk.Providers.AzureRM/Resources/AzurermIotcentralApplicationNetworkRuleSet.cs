using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_rule in .
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
        get => new TerraformReference<string>(this, "ip_mask");
        set => SetArgument("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "apply_to_device");
        set => SetArgument("apply_to_device", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    public required TerraformValue<string> IotcentralApplicationId
    {
        get => new TerraformReference<string>(this, "iotcentral_application_id");
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
