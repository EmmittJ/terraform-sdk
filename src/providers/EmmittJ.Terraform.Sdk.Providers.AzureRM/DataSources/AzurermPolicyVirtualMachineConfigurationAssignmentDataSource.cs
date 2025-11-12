using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_virtual_machine_configuration_assignment.
/// </summary>
public partial class AzurermPolicyVirtualMachineConfigurationAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSource(string name) : base("azurerm_policy_virtual_machine_configuration_assignment", name)
    {
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    [TerraformProperty("virtual_machine_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    [TerraformProperty("assignment_hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssignmentHash { get; }

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    [TerraformProperty("compliance_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComplianceStatus { get; }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    [TerraformProperty("content_hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContentHash { get; }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [TerraformProperty("content_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContentUri { get; }

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    [TerraformProperty("last_compliance_status_checked")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastComplianceStatusChecked { get; }

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    [TerraformProperty("latest_report_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestReportId { get; }

}
