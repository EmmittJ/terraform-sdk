using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_container_deployment resource.
/// </summary>
public class AzurermSpringCloudContainerDeployment : TerraformResource
{
    public AzurermSpringCloudContainerDeployment(string name) : base("azurerm_spring_cloud_container_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    public TerraformProperty<string>? AddonJson
    {
        get => GetProperty<TerraformProperty<string>>("addon_json");
        set => this.WithProperty("addon_json", value);
    }

    /// <summary>
    /// The application_performance_monitoring_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ApplicationPerformanceMonitoringIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("application_performance_monitoring_ids");
        set => this.WithProperty("application_performance_monitoring_ids", value);
    }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Arguments
    {
        get => GetProperty<TerraformProperty<List<string>>>("arguments");
        set => this.WithProperty("arguments", value);
    }

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Commands
    {
        get => GetProperty<TerraformProperty<List<string>>>("commands");
        set => this.WithProperty("commands", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMapProperty<string>? EnvironmentVariables
    {
        get => GetProperty<TerraformMapProperty<string>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
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
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => this.WithProperty("image", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The language_framework attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageFramework
    {
        get => GetProperty<TerraformProperty<string>>("language_framework");
        set => this.WithProperty("language_framework", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    public TerraformProperty<string>? Server
    {
        get => GetProperty<TerraformProperty<string>>("server");
        set => this.WithProperty("server", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

}
