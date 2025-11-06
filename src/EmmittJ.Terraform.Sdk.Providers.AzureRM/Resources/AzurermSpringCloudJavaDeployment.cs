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
    public Dictionary<string, string>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables")?.Value;
        set => this.WithProperty("environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The jvm_options attribute.
    /// </summary>
    public string? JvmOptions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("jvm_options")?.Value;
        set => this.WithProperty("jvm_options", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public string? RuntimeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_version")?.Value;
        set => this.WithProperty("runtime_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public string? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id")?.Value;
        set => this.WithProperty("spring_cloud_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
