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
    public string? ActivitiesJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("activities_json")?.Value;
        set => this.WithProperty("activities_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    public double? Concurrency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("concurrency")?.Value;
        set => this.WithProperty("concurrency", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The moniter_metrics_after_duration attribute.
    /// </summary>
    public string? MoniterMetricsAfterDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("moniter_metrics_after_duration")?.Value;
        set => this.WithProperty("moniter_metrics_after_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, string>? Variables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("variables")?.Value;
        set => this.WithProperty("variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
