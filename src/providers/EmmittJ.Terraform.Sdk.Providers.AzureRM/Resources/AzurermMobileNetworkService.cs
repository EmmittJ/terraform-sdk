using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pcc_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkServicePccRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    [TerraformProperty("precedence")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Precedence { get; set; }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    [TerraformProperty("traffic_control_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TrafficControlEnabled { get; set; }

}

/// <summary>
/// Block type for service_qos_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkServiceServiceQosPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    [TerraformProperty("allocation_and_retention_priority_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AllocationAndRetentionPriorityLevel { get; set; }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    [TerraformProperty("preemption_capability")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreemptionCapability { get; set; }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    [TerraformProperty("preemption_vulnerability")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreemptionVulnerability { get; set; }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    [TerraformProperty("qos_indicator")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QosIndicator { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkServiceTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mobile_network_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMobileNetworkService : TerraformResource
{
    public AzurermMobileNetworkService(string name) : base("azurerm_mobile_network_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformProperty("mobile_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    [TerraformProperty("service_precedence")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ServicePrecedence { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for pcc_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PccRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    [TerraformProperty("pcc_rule")]
    public partial TerraformList<TerraformBlock<AzurermMobileNetworkServicePccRuleBlock>>? PccRule { get; set; }

    /// <summary>
    /// Block for service_qos_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    [TerraformProperty("service_qos_policy")]
    public partial TerraformList<TerraformBlock<AzurermMobileNetworkServiceServiceQosPolicyBlock>>? ServiceQosPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMobileNetworkServiceTimeoutsBlock>? Timeouts { get; set; }

}
