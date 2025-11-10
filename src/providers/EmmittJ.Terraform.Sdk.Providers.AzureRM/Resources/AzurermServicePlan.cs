using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicePlanTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_service_plan resource.
/// </summary>
public class AzurermServicePlan : TerraformResource
{
    public AzurermServicePlan(string name) : base("azurerm_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("kind");
        SetOutput("reserved");
        SetOutput("app_service_environment_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("maximum_elastic_worker_count");
        SetOutput("name");
        SetOutput("os_type");
        SetOutput("per_site_scaling_enabled");
        SetOutput("premium_plan_auto_scale_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("worker_count");
        SetOutput("zone_balancing_enabled");
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformProperty<string> AppServiceEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_environment_id");
        set => SetProperty("app_service_environment_id", value);
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
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformProperty<double> MaximumElasticWorkerCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_elastic_worker_count");
        set => SetProperty("maximum_elastic_worker_count", value);
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
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PerSiteScalingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("per_site_scaling_enabled");
        set => SetProperty("per_site_scaling_enabled", value);
    }

    /// <summary>
    /// The premium_plan_auto_scale_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PremiumPlanAutoScaleEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("premium_plan_auto_scale_enabled");
        set => SetProperty("premium_plan_auto_scale_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformProperty<double> WorkerCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("worker_count");
        set => SetProperty("worker_count", value);
    }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneBalancingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_balancing_enabled");
        set => SetProperty("zone_balancing_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicePlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformExpression Reserved => this["reserved"];

}
