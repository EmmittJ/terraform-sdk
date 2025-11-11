using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionPolicyRemediationTimeoutsBlock
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
/// Manages a azurerm_subscription_policy_remediation resource.
/// </summary>
public class AzurermSubscriptionPolicyRemediation : TerraformResource
{
    public AzurermSubscriptionPolicyRemediation(string name) : base("azurerm_subscription_policy_remediation", name)
    {
    }

    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    [TerraformPropertyName("failure_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FailurePercentage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    [TerraformPropertyName("location_filters")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LocationFilters { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    [TerraformPropertyName("parallel_deployments")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ParallelDeployments { get; set; }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    [TerraformPropertyName("policy_assignment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyAssignmentId { get; set; }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_definition_reference_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyDefinitionReferenceId { get; set; }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ResourceCount { get; set; }

    /// <summary>
    /// The resource_discovery_mode attribute.
    /// </summary>
    [TerraformPropertyName("resource_discovery_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceDiscoveryMode { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubscriptionPolicyRemediationTimeoutsBlock>? Timeouts { get; set; }

}
