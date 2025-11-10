using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemandParameterBlock : TerraformBlock
{
    /// <summary>
    /// The identifier of the synchronization rule to be applied. This rule ID is defined in the schema for a given synchronization job or template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformProperty<string> RuleId
    {
        set => SetProperty("rule_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azuread_synchronization_job_provision_on_demand resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadSynchronizationJobProvisionOnDemand : TerraformResource
{
    public AzureadSynchronizationJobProvisionOnDemand(string name) : base("azuread_synchronization_job_provision_on_demand", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("service_principal_id");
        SetOutput("synchronization_job_id");
        SetOutput("triggers");
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
    /// The object ID of the service principal for which this synchronization job should be provisioned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_id");
        set => SetProperty("service_principal_id", value);
    }

    /// <summary>
    /// The identifier for the synchronization jop.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynchronizationJobId is required")]
    public required TerraformProperty<string> SynchronizationJobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synchronization_job_id");
        set => SetProperty("synchronization_job_id", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameter block(s) required")]
    public List<AzureadSynchronizationJobProvisionOnDemandParameterBlock>? Parameter
    {
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
