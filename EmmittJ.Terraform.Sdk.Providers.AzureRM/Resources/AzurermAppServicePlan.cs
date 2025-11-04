using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_plan resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppServicePlan : TerraformResource
{
    public AzurermAppServicePlan(string name) : base("azurerm_app_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("maximum_number_of_workers");
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public string? AppServiceEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_environment_id")?.Value;
        set => this.WithProperty("app_service_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The is_xenon attribute.
    /// </summary>
    public bool? IsXenon
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_xenon")?.Value;
        set => this.WithProperty("is_xenon", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public double? MaximumElasticWorkerCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_elastic_worker_count")?.Value;
        set => this.WithProperty("maximum_elastic_worker_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The per_site_scaling attribute.
    /// </summary>
    public bool? PerSiteScaling
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("per_site_scaling")?.Value;
        set => this.WithProperty("per_site_scaling", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public bool? Reserved
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("reserved")?.Value;
        set => this.WithProperty("reserved", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public bool? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant")?.Value;
        set => this.WithProperty("zone_redundant", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

}
