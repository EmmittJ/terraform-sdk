using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServicePlanDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformArgument("app_service_environment_id")]
    public TerraformValue<string> AppServiceEnvironmentId
    {
        get => new TerraformReference<string>(this, "app_service_environment_id");
    }

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    [TerraformArgument("is_xenon")]
    public TerraformValue<bool> IsXenon
    {
        get => new TerraformReference<bool>(this, "is_xenon");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    [TerraformArgument("maximum_elastic_worker_count")]
    public TerraformValue<double> MaximumElasticWorkerCount
    {
        get => new TerraformReference<double>(this, "maximum_elastic_worker_count");
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    [TerraformArgument("maximum_number_of_workers")]
    public TerraformValue<double> MaximumNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "maximum_number_of_workers");
    }

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    [TerraformArgument("per_site_scaling")]
    public TerraformValue<bool> PerSiteScaling
    {
        get => new TerraformReference<bool>(this, "per_site_scaling");
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformArgument("reserved")]
    public TerraformValue<bool> Reserved
    {
        get => new TerraformReference<bool>(this, "reserved");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformList<object> Sku
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

}
