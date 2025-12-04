using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermMonitorActivityLogAlert.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    public required TerraformValue<string> ActionGroupId
    {
        get => GetArgument<TerraformValue<string>>("action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public TerraformMap<string>? WebhookProperties
    {
        get => GetArgument<TerraformMap<string>>("webhook_properties");
        set => SetArgument("webhook_properties", value);
    }

}


/// <summary>
/// Block type for criteria in AzurermMonitorActivityLogAlert.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// The caller attribute.
    /// </summary>
    public TerraformValue<string>? Caller
    {
        get => GetArgument<TerraformValue<string>>("caller");
        set => SetArgument("caller", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => GetArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string>? Level
    {
        get => GetArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    public TerraformList<string>? Levels
    {
        get => GetArgument<TerraformList<string>>("levels");
        set => SetArgument("levels", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformValue<string>? OperationName
    {
        get => GetArgument<TerraformValue<string>>("operation_name");
        set => SetArgument("operation_name", value);
    }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationCategory
    {
        get => GetArgument<TerraformValue<string>>("recommendation_category");
        set => SetArgument("recommendation_category", value);
    }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationImpact
    {
        get => GetArgument<TerraformValue<string>>("recommendation_impact");
        set => SetArgument("recommendation_impact", value);
    }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationType
    {
        get => GetArgument<TerraformValue<string>>("recommendation_type");
        set => SetArgument("recommendation_type", value);
    }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => GetArgument<TerraformValue<string>>("resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformList<string>? ResourceGroups
    {
        get => GetArgument<TerraformList<string>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    public TerraformList<string>? ResourceIds
    {
        get => GetArgument<TerraformList<string>>("resource_ids");
        set => SetArgument("resource_ids", value);
    }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    public TerraformValue<string>? ResourceProvider
    {
        get => GetArgument<TerraformValue<string>>("resource_provider");
        set => SetArgument("resource_provider", value);
    }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    public TerraformList<string>? ResourceProviders
    {
        get => GetArgument<TerraformList<string>>("resource_providers");
        set => SetArgument("resource_providers", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => GetArgument<TerraformList<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public TerraformList<string>? Statuses
    {
        get => GetArgument<TerraformList<string>>("statuses");
        set => SetArgument("statuses", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformValue<string>? SubStatus
    {
        get => GetArgument<TerraformValue<string>>("sub_status");
        set => SetArgument("sub_status", value);
    }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    public TerraformList<string>? SubStatuses
    {
        get => GetArgument<TerraformList<string>>("sub_statuses");
        set => SetArgument("sub_statuses", value);
    }

    /// <summary>
    /// ResourceHealth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceHealth block(s) allowed")]
    public TerraformList<AzurermMonitorActivityLogAlertCriteriaBlockResourceHealthBlock>? ResourceHealth
    {
        get => GetArgument<TerraformList<AzurermMonitorActivityLogAlertCriteriaBlockResourceHealthBlock>>("resource_health");
        set => SetArgument("resource_health", value);
    }

    /// <summary>
    /// ServiceHealth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceHealth block(s) allowed")]
    public TerraformList<AzurermMonitorActivityLogAlertCriteriaBlockServiceHealthBlock>? ServiceHealth
    {
        get => GetArgument<TerraformList<AzurermMonitorActivityLogAlertCriteriaBlockServiceHealthBlock>>("service_health");
        set => SetArgument("service_health", value);
    }

}

/// <summary>
/// Block type for resource_health in AzurermMonitorActivityLogAlertCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertCriteriaBlockResourceHealthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_health";

    /// <summary>
    /// The current attribute.
    /// </summary>
    public TerraformSet<string>? Current
    {
        get => GetArgument<TerraformSet<string>>("current");
        set => SetArgument("current", value);
    }

    /// <summary>
    /// The previous attribute.
    /// </summary>
    public TerraformSet<string>? Previous
    {
        get => GetArgument<TerraformSet<string>>("previous");
        set => SetArgument("previous", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    public TerraformSet<string>? Reason
    {
        get => GetArgument<TerraformSet<string>>("reason");
        set => SetArgument("reason", value);
    }

}

/// <summary>
/// Block type for service_health in AzurermMonitorActivityLogAlertCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertCriteriaBlockServiceHealthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_health";

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformSet<string>? Events
    {
        get => GetArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformSet<string>? Locations
    {
        get => GetArgument<TerraformSet<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    public TerraformSet<string>? Services
    {
        get => GetArgument<TerraformSet<string>>("services");
        set => SetArgument("services", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorActivityLogAlert.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActivityLogAlertTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_activity_log_alert Terraform resource.
/// Manages a azurerm_monitor_activity_log_alert resource.
/// </summary>
public partial class AzurermMonitorActivityLogAlert(string name) : TerraformResource("azurerm_monitor_activity_log_alert", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => GetArgument<TerraformSet<string>>("scopes");
        set => SetArgument("scopes", value);
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
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActivityLogAlertActionBlock>? Action
    {
        get => GetArgument<TerraformList<AzurermMonitorActivityLogAlertActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public required TerraformList<AzurermMonitorActivityLogAlertCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorActivityLogAlertCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorActivityLogAlertTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorActivityLogAlertTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
