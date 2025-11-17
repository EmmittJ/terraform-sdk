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
        get => new TerraformReference<string>(this, "action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public TerraformMap<string>? WebhookProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "webhook_properties").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "caller");
        set => SetArgument("caller", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string>? Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    public TerraformList<string>? Levels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "levels").ResolveNodes(ctx));
        set => SetArgument("levels", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformValue<string>? OperationName
    {
        get => new TerraformReference<string>(this, "operation_name");
        set => SetArgument("operation_name", value);
    }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationCategory
    {
        get => new TerraformReference<string>(this, "recommendation_category");
        set => SetArgument("recommendation_category", value);
    }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationImpact
    {
        get => new TerraformReference<string>(this, "recommendation_impact");
        set => SetArgument("recommendation_impact", value);
    }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    public TerraformValue<string>? RecommendationType
    {
        get => new TerraformReference<string>(this, "recommendation_type");
        set => SetArgument("recommendation_type", value);
    }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformList<string>? ResourceGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_groups").ResolveNodes(ctx));
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    public TerraformList<string>? ResourceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_ids").ResolveNodes(ctx));
        set => SetArgument("resource_ids", value);
    }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    public TerraformValue<string>? ResourceProvider
    {
        get => new TerraformReference<string>(this, "resource_provider");
        set => SetArgument("resource_provider", value);
    }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    public TerraformList<string>? ResourceProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_providers").ResolveNodes(ctx));
        set => SetArgument("resource_providers", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public TerraformList<string>? Statuses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "statuses").ResolveNodes(ctx));
        set => SetArgument("statuses", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformValue<string>? SubStatus
    {
        get => new TerraformReference<string>(this, "sub_status");
        set => SetArgument("sub_status", value);
    }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    public TerraformList<string>? SubStatuses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sub_statuses").ResolveNodes(ctx));
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "current").ResolveNodes(ctx));
        set => SetArgument("current", value);
    }

    /// <summary>
    /// The previous attribute.
    /// </summary>
    public TerraformSet<string>? Previous
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "previous").ResolveNodes(ctx));
        set => SetArgument("previous", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    public TerraformSet<string>? Reason
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "reason").ResolveNodes(ctx));
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformSet<string>? Locations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "locations").ResolveNodes(ctx));
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    public TerraformSet<string>? Services
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "services").ResolveNodes(ctx));
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
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
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
