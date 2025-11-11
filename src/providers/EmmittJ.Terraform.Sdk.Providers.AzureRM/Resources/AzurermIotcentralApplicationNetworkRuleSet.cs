using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    [TerraformProperty("ip_mask")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpMask { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_iotcentral_application_network_rule_set resource.
/// </summary>
public partial class AzurermIotcentralApplicationNetworkRuleSet : TerraformResource
{
    public AzurermIotcentralApplicationNetworkRuleSet(string name) : base("azurerm_iotcentral_application_network_rule_set", name)
    {
    }

    /// <summary>
    /// The apply_to_device attribute.
    /// </summary>
    [TerraformProperty("apply_to_device")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyToDevice { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultAction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    [TerraformProperty("iotcentral_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IotcentralApplicationId { get; set; }

    /// <summary>
    /// Block for ip_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ip_rule")]
    public partial TerraformList<TerraformBlock<AzurermIotcentralApplicationNetworkRuleSetIpRuleBlock>>? IpRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermIotcentralApplicationNetworkRuleSetTimeoutsBlock>? Timeouts { get; set; }

}
