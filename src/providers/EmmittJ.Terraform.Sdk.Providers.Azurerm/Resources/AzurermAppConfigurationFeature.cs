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
        get => GetRequiredArgument<TerraformValue<double>>("default_rollout_percentage");
        set => SetArgument("default_rollout_percentage", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformList<string>? Users
    {
        get => GetArgument<TerraformList<string>>("users");
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RolloutPercentage is required")]
    public required TerraformValue<double> RolloutPercentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("rollout_percentage");
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
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
        get => GetRequiredArgument<TerraformValue<string>>("configuration_store_id");
        set => SetArgument("configuration_store_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => GetArgument<TerraformValue<string>>("etag") ?? CreateReference("etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? CreateReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformValue<bool>? Locked
    {
        get => GetArgument<TerraformValue<bool>>("locked");
        set => SetArgument("locked", value);
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
    /// The percentage_filter_value attribute.
    /// </summary>
    public TerraformValue<double>? PercentageFilterValue
    {
        get => GetArgument<TerraformValue<double>>("percentage_filter_value");
        set => SetArgument("percentage_filter_value", value);
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
