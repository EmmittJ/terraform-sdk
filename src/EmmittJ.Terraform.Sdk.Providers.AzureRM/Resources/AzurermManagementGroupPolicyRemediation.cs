using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<double>? FailurePercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failure_percentage");
        set => this.WithProperty("failure_percentage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LocationFilters
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("location_filters");
        set => this.WithProperty("location_filters", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ParallelDeployments
    {
        get => GetProperty<TerraformLiteralProperty<double>>("parallel_deployments");
        set => this.WithProperty("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyAssignmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_assignment_id");
        set => this.WithProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyDefinitionReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_definition_reference_id");
        set => this.WithProperty("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ResourceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("resource_count");
        set => this.WithProperty("resource_count", value);
    }

}
