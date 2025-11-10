using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicePlanDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_service_plan.
/// </summary>
public class AzurermServicePlanDataSource : TerraformDataSource
{
    public AzurermServicePlanDataSource(string name) : base("azurerm_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_environment_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("maximum_elastic_worker_count");
        this.DeclareOutput("os_type");
        this.DeclareOutput("per_site_scaling_enabled");
        this.DeclareOutput("reserved");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("worker_count");
        this.DeclareOutput("zone_balancing_enabled");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicePlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServicePlanDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformExpression AppServiceEnvironmentId => this["app_service_environment_id"];

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
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public TerraformExpression PerSiteScalingEnabled => this["per_site_scaling_enabled"];

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformExpression Reserved => this["reserved"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformExpression WorkerCount => this["worker_count"];

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public TerraformExpression ZoneBalancingEnabled => this["zone_balancing_enabled"];

}
