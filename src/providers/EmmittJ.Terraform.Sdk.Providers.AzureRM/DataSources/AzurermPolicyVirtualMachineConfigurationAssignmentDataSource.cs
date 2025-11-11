using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_virtual_machine_configuration_assignment.
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSource(string name) : base("azurerm_policy_virtual_machine_configuration_assignment", name)
    {
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    [TerraformPropertyName("virtual_machine_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualMachineName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    [TerraformPropertyName("assignment_hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssignmentHash => new TerraformReference(this, "assignment_hash");

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    [TerraformPropertyName("compliance_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComplianceStatus => new TerraformReference(this, "compliance_status");

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    [TerraformPropertyName("content_hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentHash => new TerraformReference(this, "content_hash");

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [TerraformPropertyName("content_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentUri => new TerraformReference(this, "content_uri");

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    [TerraformPropertyName("last_compliance_status_checked")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastComplianceStatusChecked => new TerraformReference(this, "last_compliance_status_checked");

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    [TerraformPropertyName("latest_report_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestReportId => new TerraformReference(this, "latest_report_id");

}
