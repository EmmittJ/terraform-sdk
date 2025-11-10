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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("assignment_hash");
        this.WithOutput("compliance_status");
        this.WithOutput("content_hash");
        this.WithOutput("content_uri");
        this.WithOutput("last_compliance_status_checked");
        this.WithOutput("latest_report_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineName is required")]
    public required TerraformProperty<string> VirtualMachineName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("virtual_machine_name");
        set => this.WithProperty("virtual_machine_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPolicyVirtualMachineConfigurationAssignmentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
