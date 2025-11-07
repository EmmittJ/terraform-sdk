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
    public TerraformProperty<string>? AppServiceEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_environment_id");
        set => this.WithProperty("app_service_environment_id", value);
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
    /// The is_xenon attribute.
    /// </summary>
    public TerraformProperty<bool>? IsXenon
    {
        get => GetProperty<TerraformProperty<bool>>("is_xenon");
        set => this.WithProperty("is_xenon", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
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
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumElasticWorkerCount
    {
        get => GetProperty<TerraformProperty<double>>("maximum_elastic_worker_count");
        set => this.WithProperty("maximum_elastic_worker_count", value);
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
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformProperty<bool>? PerSiteScaling
    {
        get => GetProperty<TerraformProperty<bool>>("per_site_scaling");
        set => this.WithProperty("per_site_scaling", value);
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformProperty<bool>? Reserved
    {
        get => GetProperty<TerraformProperty<bool>>("reserved");
        set => this.WithProperty("reserved", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

}
