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
    /// The os_type attribute.
    /// </summary>
    public string? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type")?.Value;
        set => this.WithProperty("os_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public bool? PerSiteScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("per_site_scaling_enabled")?.Value;
        set => this.WithProperty("per_site_scaling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The premium_plan_auto_scale_enabled attribute.
    /// </summary>
    public bool? PremiumPlanAutoScaleEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("premium_plan_auto_scale_enabled")?.Value;
        set => this.WithProperty("premium_plan_auto_scale_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The worker_count attribute.
    /// </summary>
    public double? WorkerCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("worker_count")?.Value;
        set => this.WithProperty("worker_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public bool? ZoneBalancingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_balancing_enabled")?.Value;
        set => this.WithProperty("zone_balancing_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
