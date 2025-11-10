using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pcc_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServicePccRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    [TerraformPropertyName("precedence")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Precedence { get; set; }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("traffic_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrafficControlEnabled { get; set; }

}

/// <summary>
/// Block type for service_qos_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServiceServiceQosPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    [TerraformPropertyName("allocation_and_retention_priority_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AllocationAndRetentionPriorityLevel { get; set; }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    [TerraformPropertyName("preemption_capability")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreemptionCapability { get; set; }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    [TerraformPropertyName("preemption_vulnerability")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreemptionVulnerability { get; set; }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    [TerraformPropertyName("qos_indicator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QosIndicator { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkServiceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformPropertyName("mobile_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MobileNetworkId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    [TerraformPropertyName("service_precedence")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ServicePrecedence { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for pcc_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PccRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    [TerraformPropertyName("pcc_rule")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkServicePccRuleBlock>>? PccRule { get; set; } = new();

    /// <summary>
    /// Block for service_qos_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    [TerraformPropertyName("service_qos_policy")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkServiceServiceQosPolicyBlock>>? ServiceQosPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkServiceTimeoutsBlock>? Timeouts { get; set; } = new();

}
