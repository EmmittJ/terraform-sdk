using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    [TerraformArgument("virtual_machine_name")]
    public required TerraformValue<string> VirtualMachineName
    {
        get => new TerraformReference<string>(this, "virtual_machine_name");
        set => SetArgument("virtual_machine_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    [TerraformArgument("assignment_hash")]
    public TerraformValue<string> AssignmentHash
    {
        get => new TerraformReference<string>(this, "assignment_hash");
    }

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    [TerraformArgument("compliance_status")]
    public TerraformValue<string> ComplianceStatus
    {
        get => new TerraformReference<string>(this, "compliance_status");
    }

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    [TerraformArgument("content_hash")]
    public TerraformValue<string> ContentHash
    {
        get => new TerraformReference<string>(this, "content_hash");
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [TerraformArgument("content_uri")]
    public TerraformValue<string> ContentUri
    {
        get => new TerraformReference<string>(this, "content_uri");
    }

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    [TerraformArgument("last_compliance_status_checked")]
    public TerraformValue<string> LastComplianceStatusChecked
    {
        get => new TerraformReference<string>(this, "last_compliance_status_checked");
    }

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    [TerraformArgument("latest_report_id")]
    public TerraformValue<string> LatestReportId
    {
        get => new TerraformReference<string>(this, "latest_report_id");
    }

}
