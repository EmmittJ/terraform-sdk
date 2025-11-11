using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkSecurityRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_network_security_rule resource.
/// </summary>
public partial class AzurermNetworkSecurityRule : TerraformResource
{
    public AzurermNetworkSecurityRule(string name) : base("azurerm_network_security_rule", name)
    {
    }

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    [TerraformProperty("access")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Access { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    [TerraformProperty("destination_address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationAddressPrefix { get; set; }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    [TerraformProperty("destination_address_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("destination_application_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DestinationApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    [TerraformProperty("destination_port_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationPortRange { get; set; }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    [TerraformProperty("destination_port_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DestinationPortRanges { get; set; }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformProperty("direction")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Direction { get; set; }

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
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    [TerraformProperty("network_security_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkSecurityGroupName { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    [TerraformProperty("source_address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceAddressPrefix { get; set; }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    [TerraformProperty("source_address_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SourceAddressPrefixes { get; set; }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("source_application_security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SourceApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    [TerraformProperty("source_port_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourcePortRange { get; set; }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    [TerraformProperty("source_port_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SourcePortRanges { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNetworkSecurityRuleTimeoutsBlock>? Timeouts { get; set; }

}
