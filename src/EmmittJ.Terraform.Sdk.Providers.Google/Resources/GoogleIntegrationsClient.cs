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
    public bool? CreateSampleIntegrations
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_sample_integrations")?.Value;
        set => this.WithProperty("create_sample_integrations", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Location in which client needs to be provisioned.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? RunAsServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_as_service_account")?.Value;
        set => this.WithProperty("run_as_service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
