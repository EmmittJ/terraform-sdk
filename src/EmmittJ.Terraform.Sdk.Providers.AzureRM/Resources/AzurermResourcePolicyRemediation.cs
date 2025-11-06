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
    public double? FailurePercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failure_percentage")?.Value;
        set => this.WithProperty("failure_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    public List<string>? LocationFilters
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("location_filters")?.Value;
        set => this.WithProperty("location_filters", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    public double? ParallelDeployments
    {
        get => GetProperty<TerraformLiteralProperty<double>>("parallel_deployments")?.Value;
        set => this.WithProperty("parallel_deployments", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    public string? PolicyAssignmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_assignment_id")?.Value;
        set => this.WithProperty("policy_assignment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public string? PolicyDefinitionReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_definition_reference_id")?.Value;
        set => this.WithProperty("policy_definition_reference_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public double? ResourceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("resource_count")?.Value;
        set => this.WithProperty("resource_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_discovery_mode attribute.
    /// </summary>
    public string? ResourceDiscoveryMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_discovery_mode")?.Value;
        set => this.WithProperty("resource_discovery_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
