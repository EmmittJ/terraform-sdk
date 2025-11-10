using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicyRemediationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_management_group_policy_remediation resource.
/// </summary>
public class AzurermManagementGroupPolicyRemediation : TerraformResource
{
    public AzurermManagementGroupPolicyRemediation(string name) : base("azurerm_management_group_policy_remediation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailurePercentage
    {
        get => GetProperty<TerraformProperty<double>>("failure_percentage");
        set => this.WithProperty("failure_percentage", value);
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
    /// The location_filters attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocationFilters
    {
        get => GetProperty<List<TerraformProperty<string>>>("location_filters");
        set => this.WithProperty("location_filters", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    public TerraformProperty<double>? ParallelDeployments
    {
        get => GetProperty<TerraformProperty<double>>("parallel_deployments");
        set => this.WithProperty("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformProperty<string> PolicyAssignmentId
    {
        get => GetProperty<TerraformProperty<string>>("policy_assignment_id");
        set => this.WithProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDefinitionReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("policy_definition_reference_id");
        set => this.WithProperty("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformProperty<double>? ResourceCount
    {
        get => GetProperty<TerraformProperty<double>>("resource_count");
        set => this.WithProperty("resource_count", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagementGroupPolicyRemediationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagementGroupPolicyRemediationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
