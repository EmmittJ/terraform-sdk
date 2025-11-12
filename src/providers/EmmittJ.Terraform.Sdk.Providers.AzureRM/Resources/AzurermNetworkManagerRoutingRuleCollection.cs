using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_network_manager_routing_rule_collection resource.
/// </summary>
public partial class AzurermNetworkManagerRoutingRuleCollection : TerraformResource
{
    public AzurermNetworkManagerRoutingRuleCollection(string name) : base("azurerm_network_manager_routing_rule_collection", name)
    {
    }

    /// <summary>
    /// The bgp_route_propagation_enabled attribute.
    /// </summary>
    [TerraformProperty("bgp_route_propagation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BgpRoutePropagationEnabled { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    [TerraformProperty("network_group_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? NetworkGroupIds { get; set; }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfigurationId is required")]
    [TerraformProperty("routing_configuration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoutingConfigurationId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock Timeouts { get; set; } = new();

}
