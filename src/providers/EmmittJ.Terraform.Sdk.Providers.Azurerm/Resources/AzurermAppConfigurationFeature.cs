using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for targeting_filter in AzurermAppConfigurationFeature.
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
    public required TerraformValue<double> DefaultRolloutPercentage
    {
        get => new TerraformReference<double>(this, "default_rollout_percentage");
        set => SetArgument("default_rollout_percentage", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformList<string>? Users
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "users").ResolveNodes(ctx));
        set => SetArgument("users", value);
    }

    /// <summary>
    /// Groups block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAppConfigurationFeatureTargetingFilterBlockGroupsBlock>? Groups
    {
        get => GetArgument<TerraformList<AzurermAppConfigurationFeatureTargetingFilterBlockGroupsBlock>>("groups");
        set => SetArgument("groups", value);
    }

}

/// <summary>
/// Block type for groups in AzurermAppConfigurationFeatureTargetingFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTargetingFilterBlockGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "groups";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RolloutPercentage is required")]
    public required TerraformValue<double> RolloutPercentage
    {
        get => new TerraformReference<double>(this, "rollout_percentage");
        set => SetArgument("rollout_percentage", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppConfigurationFeature.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for timewindow_filter in AzurermAppConfigurationFeature.
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
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Represents a azurerm_app_configuration_feature Terraform resource.
/// Manages a azurerm_app_configuration_feature resource.
/// </summary>
public partial class AzurermAppConfigurationFeature(string name) : TerraformResource("azurerm_app_configuration_feature", name)
{
    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformValue<string> ConfigurationStoreId
    {
        get => new TerraformReference<string>(this, "configuration_store_id");
        set => SetArgument("configuration_store_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformValue<bool>? Locked
    {
        get => new TerraformReference<bool>(this, "locked");
        set => SetArgument("locked", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The percentage_filter_value attribute.
    /// </summary>
    public TerraformValue<double>? PercentageFilterValue
    {
        get => new TerraformReference<double>(this, "percentage_filter_value");
        set => SetArgument("percentage_filter_value", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// TargetingFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAppConfigurationFeatureTargetingFilterBlock>? TargetingFilter
    {
        get => GetArgument<TerraformList<AzurermAppConfigurationFeatureTargetingFilterBlock>>("targeting_filter");
        set => SetArgument("targeting_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppConfigurationFeatureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppConfigurationFeatureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TimewindowFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAppConfigurationFeatureTimewindowFilterBlock>? TimewindowFilter
    {
        get => GetArgument<TerraformList<AzurermAppConfigurationFeatureTimewindowFilterBlock>>("timewindow_filter");
        set => SetArgument("timewindow_filter", value);
    }

}
