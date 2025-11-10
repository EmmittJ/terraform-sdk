using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePlanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_plan.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermAppServicePlanDataSource : TerraformDataSource
{
    public AzurermAppServicePlanDataSource(string name) : base("azurerm_app_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_service_environment_id");
        this.WithOutput("is_xenon");
        this.WithOutput("kind");
        this.WithOutput("location");
        this.WithOutput("maximum_elastic_worker_count");
        this.WithOutput("maximum_number_of_workers");
        this.WithOutput("per_site_scaling");
        this.WithOutput("reserved");
        this.WithOutput("sku");
        this.WithOutput("tags");
        this.WithOutput("zone_redundant");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServicePlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServicePlanDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformExpression AppServiceEnvironmentId => this["app_service_environment_id"];

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    public TerraformExpression IsXenon => this["is_xenon"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformExpression MaximumElasticWorkerCount => this["maximum_elastic_worker_count"];

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformExpression PerSiteScaling => this["per_site_scaling"];

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformExpression Reserved => this["reserved"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformExpression ZoneRedundant => this["zone_redundant"];

}
