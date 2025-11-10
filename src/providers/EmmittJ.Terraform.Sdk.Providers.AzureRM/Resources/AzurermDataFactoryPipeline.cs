using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryPipelineTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_pipeline resource.
/// </summary>
public class AzurermDataFactoryPipeline : TerraformResource
{
    public AzurermDataFactoryPipeline(string name) : base("azurerm_data_factory_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activities_json");
        SetOutput("annotations");
        SetOutput("concurrency");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("folder");
        SetOutput("id");
        SetOutput("moniter_metrics_after_duration");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("variables");
    }

    /// <summary>
    /// The activities_json attribute.
    /// </summary>
    public TerraformProperty<string> ActivitiesJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("activities_json");
        set => SetProperty("activities_json", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    public TerraformProperty<double> Concurrency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("concurrency");
        set => SetProperty("concurrency", value);
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
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string> Folder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder");
        set => SetProperty("folder", value);
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
    /// The moniter_metrics_after_duration attribute.
    /// </summary>
    public TerraformProperty<string> MoniterMetricsAfterDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("moniter_metrics_after_duration");
        set => SetProperty("moniter_metrics_after_duration", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Variables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("variables");
        set => SetProperty("variables", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryPipelineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
