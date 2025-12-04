using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicePlan.
/// Nesting mode: single
/// </summary>
public class AzurermServicePlanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_service_plan Terraform resource.
/// Manages a azurerm_service_plan resource.
/// </summary>
public partial class AzurermServicePlan(string name) : TerraformResource("azurerm_service_plan", name)
{
    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformValue<string>? AppServiceEnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("app_service_environment_id");
        set => SetArgument("app_service_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformValue<double> MaximumElasticWorkerCount
    {
        get => GetArgument<TerraformValue<double>>("maximum_elastic_worker_count") ?? AsReference("maximum_elastic_worker_count");
        set => SetArgument("maximum_elastic_worker_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformValue<string> OsType
    {
        get => GetRequiredArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PerSiteScalingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("per_site_scaling_enabled");
        set => SetArgument("per_site_scaling_enabled", value);
    }

    /// <summary>
    /// The premium_plan_auto_scale_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PremiumPlanAutoScaleEnabled
    {
        get => GetArgument<TerraformValue<bool>>("premium_plan_auto_scale_enabled");
        set => SetArgument("premium_plan_auto_scale_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformValue<double> WorkerCount
    {
        get => GetArgument<TerraformValue<double>>("worker_count") ?? AsReference("worker_count");
        set => SetArgument("worker_count", value);
    }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneBalancingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("zone_balancing_enabled");
        set => SetArgument("zone_balancing_enabled", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformValue<bool> Reserved
        => AsReference("reserved");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicePlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicePlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
