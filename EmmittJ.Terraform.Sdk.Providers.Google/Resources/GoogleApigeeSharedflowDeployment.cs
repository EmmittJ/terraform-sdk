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
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The Apigee Organization associated with the Apigee instance
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Revision of the Sharedflow to be deployed.
    /// </summary>
    public string? Revision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service account represents the identity of the deployed proxy, and determines what permissions it has. The format must be {ACCOUNT_ID}@{PROJECT}.iam.gserviceaccount.com.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Id of the Sharedflow to be deployed.
    /// </summary>
    public string? SharedflowId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sharedflow_id")?.Value;
        set => this.WithProperty("sharedflow_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
