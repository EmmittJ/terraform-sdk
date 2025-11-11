using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkManagerAdminRuleDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    [TerraformProperty("address_prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddressPrefix { get; set; }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    [TerraformProperty("address_prefix_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddressPrefixType { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkManagerAdminRuleSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    [TerraformProperty("address_prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddressPrefix { get; set; }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    [TerraformProperty("address_prefix_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddressPrefixType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerAdminRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_network_manager_admin_rule resource.
/// </summary>
public partial class AzurermNetworkManagerAdminRule : TerraformResource
{
    public AzurermNetworkManagerAdminRule(string name) : base("azurerm_network_manager_admin_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The admin_rule_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminRuleCollectionId is required")]
    [TerraformProperty("admin_rule_collection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdminRuleCollectionId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    [TerraformProperty("destination_port_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DestinationPortRanges { get; set; }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformProperty("direction")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Direction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    [TerraformProperty("source_port_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SourcePortRanges { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("destination")]
    public TerraformList<TerraformBlock<AzurermNetworkManagerAdminRuleDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("source")]
    public TerraformList<TerraformBlock<AzurermNetworkManagerAdminRuleSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNetworkManagerAdminRuleTimeoutsBlock>? Timeouts { get; set; }

}
