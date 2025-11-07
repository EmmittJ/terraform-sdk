using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_integrations_client resource.
/// </summary>
public class GoogleIntegrationsClient : TerraformResource
{
    public GoogleIntegrationsClient(string name) : base("google_integrations_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Indicates if sample integrations should be created along with provisioning.
    /// </summary>
    public TerraformProperty<bool>? CreateSampleIntegrations
    {
        get => GetProperty<TerraformProperty<bool>>("create_sample_integrations");
        set => this.WithProperty("create_sample_integrations", value);
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
    /// Location in which client needs to be provisioned.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? RunAsServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("run_as_service_account");
        set => this.WithProperty("run_as_service_account", value);
    }

}
