using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionPolicyRemediationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_subscription_policy_remediation resource.
/// </summary>
public class AzurermSubscriptionPolicyRemediation : TerraformResource
{
    public AzurermSubscriptionPolicyRemediation(string name) : base("azurerm_subscription_policy_remediation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("failure_percentage");
        SetOutput("id");
        SetOutput("location_filters");
        SetOutput("name");
        SetOutput("parallel_deployments");
        SetOutput("policy_assignment_id");
        SetOutput("policy_definition_reference_id");
        SetOutput("resource_count");
        SetOutput("resource_discovery_mode");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    public TerraformProperty<double> FailurePercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("failure_percentage");
        set => SetProperty("failure_percentage", value);
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
    /// The location_filters attribute.
    /// </summary>
    public List<TerraformProperty<string>> LocationFilters
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("location_filters");
        set => SetProperty("location_filters", value);
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
    /// The parallel_deployments attribute.
    /// </summary>
    public TerraformProperty<double> ParallelDeployments
    {
        get => GetRequiredOutput<TerraformProperty<double>>("parallel_deployments");
        set => SetProperty("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformProperty<string> PolicyAssignmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_assignment_id");
        set => SetProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformProperty<string> PolicyDefinitionReferenceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_definition_reference_id");
        set => SetProperty("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformProperty<double> ResourceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("resource_count");
        set => SetProperty("resource_count", value);
    }

    /// <summary>
    /// The resource_discovery_mode attribute.
    /// </summary>
    public TerraformProperty<string> ResourceDiscoveryMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_discovery_mode");
        set => SetProperty("resource_discovery_mode", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionPolicyRemediationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
