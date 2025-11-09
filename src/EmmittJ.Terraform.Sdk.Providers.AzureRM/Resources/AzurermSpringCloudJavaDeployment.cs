using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_java_deployment resource.
/// </summary>
public class AzurermSpringCloudJavaDeployment : TerraformResource
{
    public AzurermSpringCloudJavaDeployment(string name) : base("azurerm_spring_cloud_java_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The jvm_options attribute.
    /// </summary>
    public TerraformProperty<string>? JvmOptions
    {
        get => GetProperty<TerraformProperty<string>>("jvm_options");
        set => this.WithProperty("jvm_options", value);
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
    /// The runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => this.WithProperty("runtime_version", value);
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
