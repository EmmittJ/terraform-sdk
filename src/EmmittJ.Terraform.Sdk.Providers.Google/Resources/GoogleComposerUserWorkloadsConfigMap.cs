using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_composer_user_workloads_config_map resource.
/// </summary>
public class GoogleComposerUserWorkloadsConfigMap : TerraformResource
{
    public GoogleComposerUserWorkloadsConfigMap(string name) : base("google_composer_user_workloads_config_map", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The &amp;quot;data&amp;quot; field of Kubernetes ConfigMap, organized in key-value pairs.
    /// For details see: https://kubernetes.io/docs/concepts/configuration/configmap/
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Data
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("data");
        set => this.WithProperty("data", value);
    }

    /// <summary>
    /// Environment where the Kubernetes ConfigMap will be stored and used.
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
    /// Name of the Kubernetes ConfigMap.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The location or Compute Engine region for the environment.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
