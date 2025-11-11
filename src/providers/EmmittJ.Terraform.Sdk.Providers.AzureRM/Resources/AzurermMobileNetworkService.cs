using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pcc_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServicePccRuleBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    [TerraformPropertyName("precedence")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Precedence { get; set; }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("traffic_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TrafficControlEnabled { get; set; }

}

/// <summary>
/// Block type for service_qos_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServiceServiceQosPolicyBlock
{
    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    [TerraformPropertyName("allocation_and_retention_priority_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AllocationAndRetentionPriorityLevel { get; set; }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    [TerraformPropertyName("preemption_capability")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreemptionCapability { get; set; }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    [TerraformPropertyName("preemption_vulnerability")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreemptionVulnerability { get; set; }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    [TerraformPropertyName("qos_indicator")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? QosIndicator { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkServiceTimeoutsBlock
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
/// Manages a azurerm_mobile_network_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkService : TerraformResource
{
    public AzurermMobileNetworkService(string name) : base("azurerm_mobile_network_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformPropertyName("mobile_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    [TerraformPropertyName("service_precedence")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ServicePrecedence { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for pcc_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PccRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    [TerraformPropertyName("pcc_rule")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkServicePccRuleBlock>>? PccRule { get; set; }

    /// <summary>
    /// Block for service_qos_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    [TerraformPropertyName("service_qos_policy")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkServiceServiceQosPolicyBlock>>? ServiceQosPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkServiceTimeoutsBlock>? Timeouts { get; set; }

}
