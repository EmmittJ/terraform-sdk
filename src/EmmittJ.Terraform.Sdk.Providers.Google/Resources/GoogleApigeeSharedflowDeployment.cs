using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_sharedflow_deployment resource.
/// </summary>
public class GoogleApigeeSharedflowDeployment : TerraformResource
{
    public GoogleApigeeSharedflowDeployment(string name) : base("google_apigee_sharedflow_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// The Apigee Organization associated with the Apigee instance
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Revision of the Sharedflow to be deployed.
    /// </summary>
    public TerraformProperty<string>? Revision
    {
        get => GetProperty<TerraformProperty<string>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// The service account represents the identity of the deployed proxy, and determines what permissions it has. The format must be {ACCOUNT_ID}@{PROJECT}.iam.gserviceaccount.com.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Id of the Sharedflow to be deployed.
    /// </summary>
    public TerraformProperty<string>? SharedflowId
    {
        get => GetProperty<TerraformProperty<string>>("sharedflow_id");
        set => this.WithProperty("sharedflow_id", value);
    }

}
