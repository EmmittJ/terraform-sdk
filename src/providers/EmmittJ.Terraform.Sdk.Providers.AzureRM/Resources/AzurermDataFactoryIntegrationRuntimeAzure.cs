using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("cleanup_enabled");
        SetOutput("compute_type");
        SetOutput("core_count");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("time_to_live_min");
        SetOutput("virtual_network_enabled");
    }

    /// <summary>
    /// The cleanup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CleanupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cleanup_enabled");
        set => SetProperty("cleanup_enabled", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformProperty<string> ComputeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_type");
        set => SetProperty("compute_type", value);
    }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    public TerraformProperty<double> CoreCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("core_count");
        set => SetProperty("core_count", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The time_to_live_min attribute.
    /// </summary>
    public TerraformProperty<double> TimeToLiveMin
    {
        get => GetRequiredOutput<TerraformProperty<double>>("time_to_live_min");
        set => SetProperty("time_to_live_min", value);
    }

    /// <summary>
    /// The virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> VirtualNetworkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("virtual_network_enabled");
        set => SetProperty("virtual_network_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
