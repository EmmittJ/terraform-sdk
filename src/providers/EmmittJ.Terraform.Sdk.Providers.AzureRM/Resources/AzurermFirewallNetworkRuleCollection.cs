using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallNetworkRuleCollectionRuleBlock() : TerraformBlock("rule")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    [TerraformProperty("destination_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationAddresses { get; set; }

    /// <summary>
    /// The destination_fqdns attribute.
    /// </summary>
    [TerraformProperty("destination_fqdns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationFqdns { get; set; }

    /// <summary>
    /// The destination_ip_groups attribute.
    /// </summary>
    [TerraformProperty("destination_ip_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationIpGroups { get; set; }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    [TerraformProperty("destination_ports")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationPorts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    [TerraformProperty("protocols")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Protocols { get; set; }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    [TerraformProperty("source_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SourceAddresses { get; set; }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    [TerraformProperty("source_ip_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SourceIpGroups { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFirewallNetworkRuleCollectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_firewall_network_rule_collection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFirewallNetworkRuleCollection : TerraformResource
{
    public AzurermFirewallNetworkRuleCollection(string name) : base("azurerm_firewall_network_rule_collection", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The azure_firewall_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureFirewallName is required")]
    [TerraformProperty("azure_firewall_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AzureFirewallName { get; set; }

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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [TerraformProperty("rule")]
    public required TerraformList<AzurermFirewallNetworkRuleCollectionRuleBlock> Rule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFirewallNetworkRuleCollectionTimeoutsBlock Timeouts { get; set; } = new();

}
