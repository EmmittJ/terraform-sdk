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
    [TerraformArgument("ip_mask")]
    public required TerraformValue<string> IpMask
    {
        get => new TerraformReference<string>(this, "ip_mask");
        set => SetArgument("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
/// Manages a azurerm_iotcentral_application_network_rule_set resource.
/// </summary>
public class AzurermIotcentralApplicationNetworkRuleSet : TerraformResource
{
    public AzurermIotcentralApplicationNetworkRuleSet(string name) : base("azurerm_iotcentral_application_network_rule_set", name)
    {
    }

    /// <summary>
    /// The apply_to_device attribute.
    /// </summary>
    [TerraformArgument("apply_to_device")]
    public TerraformValue<bool>? ApplyToDevice
    {
        get => new TerraformReference<bool>(this, "apply_to_device");
        set => SetArgument("apply_to_device", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformArgument("default_action")]
    public TerraformValue<string>? DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    [TerraformArgument("iotcentral_application_id")]
    public required TerraformValue<string> IotcentralApplicationId
    {
        get => new TerraformReference<string>(this, "iotcentral_application_id");
        set => SetArgument("iotcentral_application_id", value);
    }

    /// <summary>
    /// Block for ip_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ip_rule")]
    public TerraformList<AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock> IpRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock Timeouts { get; set; } = new();

}
