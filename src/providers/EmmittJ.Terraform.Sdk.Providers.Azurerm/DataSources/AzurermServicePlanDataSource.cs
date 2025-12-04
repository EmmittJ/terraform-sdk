using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicePlanDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermServicePlanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_service_plan Terraform data source.
/// Retrieves information about a azurerm_service_plan.
/// </summary>
public partial class AzurermServicePlanDataSource(string name) : TerraformDataSource("azurerm_service_plan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformValue<string> AppServiceEnvironmentId
        => AsReference("app_service_environment_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformValue<double> MaximumElasticWorkerCount
        => AsReference("maximum_elastic_worker_count");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => AsReference("os_type");

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PerSiteScalingEnabled
        => AsReference("per_site_scaling_enabled");

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformValue<bool> Reserved
        => AsReference("reserved");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformValue<double> WorkerCount
        => AsReference("worker_count");

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ZoneBalancingEnabled
        => AsReference("zone_balancing_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicePlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicePlanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
