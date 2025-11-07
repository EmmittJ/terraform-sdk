using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Variables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("variables");
        set => this.WithProperty("variables", value);
    }

}
