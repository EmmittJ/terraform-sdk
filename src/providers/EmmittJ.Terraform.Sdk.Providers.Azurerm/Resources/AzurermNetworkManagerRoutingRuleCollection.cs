using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerRoutingRuleCollection.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_manager_routing_rule_collection Terraform resource.
/// Manages a azurerm_network_manager_routing_rule_collection resource.
/// </summary>
public partial class AzurermNetworkManagerRoutingRuleCollection(string name) : TerraformResource("azurerm_network_manager_routing_rule_collection", name)
{
    /// <summary>
    /// The bgp_route_propagation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BgpRoutePropagationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bgp_route_propagation_enabled");
        set => SetArgument("bgp_route_propagation_enabled", value);
    }

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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    public TerraformList<string>? NetworkGroupIds
    {
        get => GetArgument<TerraformList<string>>("network_group_ids");
        set => SetArgument("network_group_ids", value);
    }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfigurationId is required")]
    public required TerraformValue<string> RoutingConfigurationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("routing_configuration_id");
        set => SetArgument("routing_configuration_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
