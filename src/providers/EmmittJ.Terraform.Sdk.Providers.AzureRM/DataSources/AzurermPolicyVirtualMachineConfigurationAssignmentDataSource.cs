using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_policy_virtual_machine_configuration_assignment.
/// </summary>
public class AzurermPolicyVirtualMachineConfigurationAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSource(string name) : base("azurerm_policy_virtual_machine_configuration_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("assignment_hash");
        SetOutput("compliance_status");
        SetOutput("content_hash");
        SetOutput("content_uri");
        SetOutput("last_compliance_status_checked");
        SetOutput("latest_report_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("virtual_machine_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    public required TerraformProperty<string> VirtualMachineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_name");
        set => SetProperty("virtual_machine_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The assignment_hash attribute.
    /// </summary>
    public TerraformExpression AssignmentHash => this["assignment_hash"];

    /// <summary>
    /// The compliance_status attribute.
    /// </summary>
    public TerraformExpression ComplianceStatus => this["compliance_status"];

    /// <summary>
    /// The content_hash attribute.
    /// </summary>
    public TerraformExpression ContentHash => this["content_hash"];

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    public TerraformExpression ContentUri => this["content_uri"];

    /// <summary>
    /// The last_compliance_status_checked attribute.
    /// </summary>
    public TerraformExpression LastComplianceStatusChecked => this["last_compliance_status_checked"];

    /// <summary>
    /// The latest_report_id attribute.
    /// </summary>
    public TerraformExpression LatestReportId => this["latest_report_id"];

}
