using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<bool>(this, "bgp_route_propagation_enabled");
        set => SetArgument("bgp_route_propagation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    public TerraformList<string>? NetworkGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_group_ids").ResolveNodes(ctx));
        set => SetArgument("network_group_ids", value);
    }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfigurationId is required")]
    public required TerraformValue<string> RoutingConfigurationId
    {
        get => new TerraformReference<string>(this, "routing_configuration_id");
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
