using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourceGroupPolicyRemediationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_resource_group_policy_remediation resource.
/// </summary>
public partial class AzurermResourceGroupPolicyRemediation : TerraformResource
{
    public AzurermResourceGroupPolicyRemediation(string name) : base("azurerm_resource_group_policy_remediation", name)
    {
    }

    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    [TerraformProperty("failure_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailurePercentage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    [TerraformProperty("location_filters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LocationFilters { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    [TerraformProperty("parallel_deployments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ParallelDeployments { get; set; }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    [TerraformProperty("policy_assignment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyAssignmentId { get; set; }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    [TerraformProperty("policy_definition_reference_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyDefinitionReferenceId { get; set; }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformProperty("resource_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ResourceCount { get; set; }

    /// <summary>
    /// The resource_discovery_mode attribute.
    /// </summary>
    [TerraformProperty("resource_discovery_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceDiscoveryMode { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformProperty("resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermResourceGroupPolicyRemediationTimeoutsBlock Timeouts { get; set; } = new();

}
