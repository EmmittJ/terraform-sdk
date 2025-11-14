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
/// Block type for targeting_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTargetingFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "targeting_filter";

    /// <summary>
    /// The default_rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRolloutPercentage is required")]
    [TerraformArgument("default_rollout_percentage")]
    public required TerraformValue<double> DefaultRolloutPercentage
    {
        get => new TerraformReference<double>(this, "default_rollout_percentage");
        set => SetArgument("default_rollout_percentage", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformArgument("users")]
    public TerraformList<string>? Users
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "users").ResolveNodes(ctx));
        set => SetArgument("users", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationFeatureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for timewindow_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTimewindowFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timewindow_filter";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformArgument("end")]
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformArgument("start")]
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Manages a azurerm_app_configuration_feature resource.
/// </summary>
public class AzurermAppConfigurationFeature : TerraformResource
{
    public AzurermAppConfigurationFeature(string name) : base("azurerm_app_configuration_feature", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformArgument("configuration_store_id")]
    public required TerraformValue<string> ConfigurationStoreId
    {
        get => new TerraformReference<string>(this, "configuration_store_id");
        set => SetArgument("configuration_store_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformArgument("etag")]
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
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
    /// The key attribute.
    /// </summary>
    [TerraformArgument("key")]
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformArgument("label")]
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformArgument("locked")]
    public TerraformValue<bool>? Locked
    {
        get => new TerraformReference<bool>(this, "locked");
        set => SetArgument("locked", value);
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
    /// The percentage_filter_value attribute.
    /// </summary>
    [TerraformArgument("percentage_filter_value")]
    public TerraformValue<double>? PercentageFilterValue
    {
        get => new TerraformReference<double>(this, "percentage_filter_value");
        set => SetArgument("percentage_filter_value", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for targeting_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("targeting_filter")]
    public TerraformList<AzurermAppConfigurationFeatureTargetingFilterBlock> TargetingFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppConfigurationFeatureTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for timewindow_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("timewindow_filter")]
    public TerraformList<AzurermAppConfigurationFeatureTimewindowFilterBlock> TimewindowFilter { get; set; } = new();

}
