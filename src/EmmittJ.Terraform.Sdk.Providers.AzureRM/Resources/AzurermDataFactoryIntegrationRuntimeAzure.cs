using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_azure resource.
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzure : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzure(string name) : base("azurerm_data_factory_integration_runtime_azure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cleanup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CleanupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cleanup_enabled");
        set => this.WithProperty("cleanup_enabled", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeType
    {
        get => GetProperty<TerraformProperty<string>>("compute_type");
        set => this.WithProperty("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformProperty<double>? CoreCount
    {
        get => GetProperty<TerraformProperty<double>>("core_count");
        set => this.WithProperty("core_count", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The time_to_live_min attribute.
    /// </summary>
    public TerraformProperty<double>? TimeToLiveMin
    {
        get => GetProperty<TerraformProperty<double>>("time_to_live_min");
        set => this.WithProperty("time_to_live_min", value);
    }

    /// <summary>
    /// The virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("virtual_network_enabled");
        set => this.WithProperty("virtual_network_enabled", value);
    }

}
