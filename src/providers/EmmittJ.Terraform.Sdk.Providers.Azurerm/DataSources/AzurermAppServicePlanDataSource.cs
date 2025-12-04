using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServicePlanDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePlanDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_service_plan Terraform data source.
/// Retrieves information about a azurerm_app_service_plan.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServicePlanDataSource(string name) : TerraformDataSource("azurerm_app_service_plan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformValue<string> AppServiceEnvironmentId
        => AsReference("app_service_environment_id");

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    public TerraformValue<bool> IsXenon
        => AsReference("is_xenon");

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
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double> MaximumNumberOfWorkers
        => AsReference("maximum_number_of_workers");

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformValue<bool> PerSiteScaling
        => AsReference("per_site_scaling");

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformValue<bool> Reserved
        => AsReference("reserved");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
        => AsReference("zone_redundant");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServicePlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServicePlanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
