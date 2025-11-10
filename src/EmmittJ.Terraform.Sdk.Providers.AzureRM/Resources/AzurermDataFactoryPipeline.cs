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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The activities_json attribute.
    /// </summary>
    public TerraformProperty<string>? ActivitiesJson
    {
        get => GetProperty<TerraformProperty<string>>("activities_json");
        set => this.WithProperty("activities_json", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    public TerraformProperty<double>? Concurrency
    {
        get => GetProperty<TerraformProperty<double>>("concurrency");
        set => this.WithProperty("concurrency", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
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
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The moniter_metrics_after_duration attribute.
    /// </summary>
    public TerraformProperty<string>? MoniterMetricsAfterDuration
    {
        get => GetProperty<TerraformProperty<string>>("moniter_metrics_after_duration");
        set => this.WithProperty("moniter_metrics_after_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Variables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("variables");
        set => this.WithProperty("variables", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryPipelineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryPipelineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
