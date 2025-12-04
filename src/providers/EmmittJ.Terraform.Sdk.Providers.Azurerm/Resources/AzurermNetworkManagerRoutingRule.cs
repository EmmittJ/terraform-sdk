using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for destination in AzurermNetworkManagerRoutingRule.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerRoutingRuleDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for next_hop in AzurermNetworkManagerRoutingRule.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerRoutingRuleNextHopBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "next_hop";

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkManagerRoutingRule.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerRoutingRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_manager_routing_rule Terraform resource.
/// Manages a azurerm_network_manager_routing_rule resource.
/// </summary>
public partial class AzurermNetworkManagerRoutingRule(string name) : TerraformResource("azurerm_network_manager_routing_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rule_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleCollectionId is required")]
    public required TerraformValue<string> RuleCollectionId
    {
        get => GetArgument<TerraformValue<string>>("rule_collection_id");
        set => SetArgument("rule_collection_id", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AzurermNetworkManagerRoutingRuleDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkManagerRoutingRuleDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// NextHop block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHop is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NextHop block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NextHop block(s) allowed")]
    public required TerraformList<AzurermNetworkManagerRoutingRuleNextHopBlock> NextHop
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkManagerRoutingRuleNextHopBlock>>("next_hop");
        set => SetArgument("next_hop", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerRoutingRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerRoutingRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
