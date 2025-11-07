using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_environment_addons_config resource.
/// </summary>
public class GoogleApigeeEnvironmentAddonsConfig : TerraformResource
{
    public GoogleApigeeEnvironmentAddonsConfig(string name) : base("google_apigee_environment_addons_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Flag to enable/disable Analytics.
    /// </summary>
    public TerraformProperty<bool>? AnalyticsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("analytics_enabled");
        set => this.WithProperty("analytics_enabled", value);
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? EnvId
    {
        get => GetProperty<TerraformProperty<string>>("env_id");
        set => this.WithProperty("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
