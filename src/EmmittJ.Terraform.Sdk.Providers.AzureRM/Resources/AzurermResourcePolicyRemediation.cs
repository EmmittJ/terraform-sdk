using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_policy_remediation resource.
/// </summary>
public class AzurermResourcePolicyRemediation : TerraformResource
{
    public AzurermResourcePolicyRemediation(string name) : base("azurerm_resource_policy_remediation", name)
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
    public TerraformProperty<List<string>>? LocationFilters
    {
        get => GetProperty<TerraformProperty<List<string>>>("location_filters");
        set => this.WithProperty("location_filters", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? PolicyAssignmentId
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
    /// The resource_discovery_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceDiscoveryMode
    {
        get => GetProperty<TerraformProperty<string>>("resource_discovery_mode");
        set => this.WithProperty("resource_discovery_mode", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

}
