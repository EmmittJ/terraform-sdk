using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    [TerraformPropertyName("virtual_machine_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualMachineName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    [TerraformPropertyName("assignment_hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssignmentHash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "assignment_hash");

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    [TerraformPropertyName("compliance_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComplianceStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compliance_status");

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    [TerraformPropertyName("content_hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentHash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_hash");

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [TerraformPropertyName("content_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_uri");

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    [TerraformPropertyName("last_compliance_status_checked")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastComplianceStatusChecked => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_compliance_status_checked");

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    [TerraformPropertyName("latest_report_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestReportId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_report_id");

}
