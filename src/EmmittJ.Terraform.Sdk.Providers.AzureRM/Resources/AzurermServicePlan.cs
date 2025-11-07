using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("kind");
        this.DeclareOutput("reserved");
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppServiceEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_environment_id");
        set => this.WithProperty("app_service_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaximumElasticWorkerCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_elastic_worker_count");
        set => this.WithProperty("maximum_elastic_worker_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PerSiteScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("per_site_scaling_enabled");
        set => this.WithProperty("per_site_scaling_enabled", value);
    }

    /// <summary>
    /// The premium_plan_auto_scale_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PremiumPlanAutoScaleEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("premium_plan_auto_scale_enabled");
        set => this.WithProperty("premium_plan_auto_scale_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? WorkerCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("worker_count");
        set => this.WithProperty("worker_count", value);
    }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ZoneBalancingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_balancing_enabled");
        set => this.WithProperty("zone_balancing_enabled", value);
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
