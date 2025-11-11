using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkSecurityRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_network_security_rule resource.
/// </summary>
public class AzurermNetworkSecurityRule : TerraformResource
{
    public AzurermNetworkSecurityRule(string name) : base("azurerm_network_security_rule", name)
    {
    }

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    [TerraformPropertyName("access")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Access { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("destination_address_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationAddressPrefix { get; set; }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("destination_address_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("destination_application_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DestinationApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    [TerraformPropertyName("destination_port_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationPortRange { get; set; }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    [TerraformPropertyName("destination_port_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DestinationPortRanges { get; set; }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformPropertyName("direction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Direction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    [TerraformPropertyName("network_security_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkSecurityGroupName { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("source_address_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceAddressPrefix { get; set; }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("source_address_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceAddressPrefixes { get; set; }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("source_application_security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceApplicationSecurityGroupIds { get; set; }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    [TerraformPropertyName("source_port_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourcePortRange { get; set; }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    [TerraformPropertyName("source_port_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourcePortRanges { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkSecurityRuleTimeoutsBlock>? Timeouts { get; set; }

}
