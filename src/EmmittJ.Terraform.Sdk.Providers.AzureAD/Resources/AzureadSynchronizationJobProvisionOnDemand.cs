using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_synchronization_job_provision_on_demand resource.
/// </summary>
public class AzureadSynchronizationJobProvisionOnDemand : TerraformResource
{
    public AzureadSynchronizationJobProvisionOnDemand(string name) : base("azuread_synchronization_job_provision_on_demand", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The object ID of the service principal for which this synchronization job should be provisioned
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// The identifier for the synchronization jop.
    /// </summary>
    public TerraformProperty<string>? SynchronizationJobId
    {
        get => GetProperty<TerraformProperty<string>>("synchronization_job_id");
        set => this.WithProperty("synchronization_job_id", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMapProperty<string>? Triggers
    {
        get => GetProperty<TerraformMapProperty<string>>("triggers");
        set => this.WithProperty("triggers", value);
    }

}
