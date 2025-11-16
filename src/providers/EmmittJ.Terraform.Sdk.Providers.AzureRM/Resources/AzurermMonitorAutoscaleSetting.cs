using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for notification in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

}

/// <summary>
/// Block type for predictive in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingPredictiveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predictive";

    /// <summary>
    /// The look_ahead_time attribute.
    /// </summary>
    public TerraformValue<string>? LookAheadTime
    {
        get => new TerraformReference<string>(this, "look_ahead_time");
        set => SetArgument("look_ahead_time", value);
    }

    /// <summary>
    /// The scale_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleMode is required")]
    public required TerraformValue<string> ScaleMode
    {
        get => new TerraformReference<string>(this, "scale_mode");
        set => SetArgument("scale_mode", value);
    }

}

/// <summary>
/// Block type for profile in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "profile";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAutoscaleSettingTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_autoscale_setting Terraform resource.
/// Manages a azurerm_monitor_autoscale_setting resource.
/// </summary>
public partial class AzurermMonitorAutoscaleSetting(string name) : TerraformResource("azurerm_monitor_autoscale_setting", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Notification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notification block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingNotificationBlock>? Notification
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// Predictive block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predictive block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingPredictiveBlock>? Predictive
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingPredictiveBlock>>("predictive");
        set => SetArgument("predictive", value);
    }

    /// <summary>
    /// Profile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Profile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Profile block(s) allowed")]
    public required TerraformList<AzurermMonitorAutoscaleSettingProfileBlock> Profile
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlock>>("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorAutoscaleSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorAutoscaleSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
