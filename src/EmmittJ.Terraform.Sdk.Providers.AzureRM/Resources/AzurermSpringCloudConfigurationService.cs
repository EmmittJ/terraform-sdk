using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public class AzurermSpringCloudConfigurationService : TerraformResource
{
    public AzurermSpringCloudConfigurationService(string name) : base("azurerm_spring_cloud_configuration_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformProperty<string>? Generation
    {
        get => GetProperty<TerraformProperty<string>>("generation");
        set => this.WithProperty("generation", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RefreshIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("refresh_interval_in_seconds");
        set => this.WithProperty("refresh_interval_in_seconds", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

}
