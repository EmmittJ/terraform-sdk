using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_policy_virtual_machine_configuration_assignment Terraform data source.
/// Retrieves information about a azurerm_policy_virtual_machine_configuration_assignment.
/// </summary>
public partial class AzurermPolicyVirtualMachineConfigurationAssignmentDataSource(string name) : TerraformDataSource("azurerm_policy_virtual_machine_configuration_assignment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    public required TerraformValue<string> VirtualMachineName
    {
        get => new TerraformReference<string>(this, "virtual_machine_name");
        set => SetArgument("virtual_machine_name", value);
    }

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    public TerraformValue<string> AssignmentHash
    {
        get => new TerraformReference<string>(this, "assignment_hash");
    }

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    public TerraformValue<string> ComplianceStatus
    {
        get => new TerraformReference<string>(this, "compliance_status");
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformValue<string> ContentHash
    {
        get => new TerraformReference<string>(this, "content_hash");
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public TerraformValue<string> ContentUri
    {
        get => new TerraformReference<string>(this, "content_uri");
    }

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    public TerraformValue<string> LastComplianceStatusChecked
    {
        get => new TerraformReference<string>(this, "last_compliance_status_checked");
    }

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    public TerraformValue<string> LatestReportId
    {
        get => new TerraformReference<string>(this, "latest_report_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
