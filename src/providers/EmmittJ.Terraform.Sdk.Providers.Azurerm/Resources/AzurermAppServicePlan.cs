using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sku in AzurermAppServicePlan.
/// Nesting mode: list
/// </summary>
public class AzurermAppServicePlanSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<string> Size
    {
        get => GetArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppServicePlan.
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePlanTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_service_plan Terraform resource.
/// Manages a azurerm_app_service_plan resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServicePlan(string name) : TerraformResource("azurerm_app_service_plan", name)
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    public TerraformValue<bool>? IsXenon
    {
        get => GetArgument<TerraformValue<bool>>("is_xenon");
        set => SetArgument("is_xenon", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformValue<double>? MaximumElasticWorkerCount
    {
        get => GetArgument<TerraformValue<double>>("maximum_elastic_worker_count");
        set => SetArgument("maximum_elastic_worker_count", value);
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
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformValue<bool>? PerSiteScaling
    {
        get => GetArgument<TerraformValue<bool>>("per_site_scaling");
        set => SetArgument("per_site_scaling", value);
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformValue<bool>? Reserved
    {
        get => GetArgument<TerraformValue<bool>>("reserved");
        set => SetArgument("reserved", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double> MaximumNumberOfWorkers
        => AsReference("maximum_number_of_workers");

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermAppServicePlanSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermAppServicePlanSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServicePlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServicePlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
