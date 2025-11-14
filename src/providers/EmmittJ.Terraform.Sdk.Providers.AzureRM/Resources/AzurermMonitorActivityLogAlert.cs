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
/// Block type for action in .
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
    [TerraformArgument("action_group_id")]
    public required TerraformValue<string> ActionGroupId
    {
        get => new TerraformReference<string>(this, "action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformArgument("webhook_properties")]
    public TerraformMap<string>? WebhookProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "webhook_properties").ResolveNodes(ctx));
        set => SetArgument("webhook_properties", value);
    }

}

/// <summary>
/// Block type for criteria in .
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
    [TerraformArgument("caller")]
    public TerraformValue<string>? Caller
    {
        get => new TerraformReference<string>(this, "caller");
        set => SetArgument("caller", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformArgument("category")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformArgument("level")]
    public TerraformValue<string>? Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    [TerraformArgument("levels")]
    public TerraformList<string>? Levels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "levels").ResolveNodes(ctx));
        set => SetArgument("levels", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformArgument("operation_name")]
    public TerraformValue<string>? OperationName
    {
        get => new TerraformReference<string>(this, "operation_name");
        set => SetArgument("operation_name", value);
    }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    [TerraformArgument("recommendation_category")]
    public TerraformValue<string>? RecommendationCategory
    {
        get => new TerraformReference<string>(this, "recommendation_category");
        set => SetArgument("recommendation_category", value);
    }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    [TerraformArgument("recommendation_impact")]
    public TerraformValue<string>? RecommendationImpact
    {
        get => new TerraformReference<string>(this, "recommendation_impact");
        set => SetArgument("recommendation_impact", value);
    }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    [TerraformArgument("recommendation_type")]
    public TerraformValue<string>? RecommendationType
    {
        get => new TerraformReference<string>(this, "recommendation_type");
        set => SetArgument("recommendation_type", value);
    }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    [TerraformArgument("resource_group")]
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    [TerraformArgument("resource_groups")]
    public TerraformList<string>? ResourceGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_groups").ResolveNodes(ctx));
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string>? ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    [TerraformArgument("resource_ids")]
    public TerraformList<string>? ResourceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_ids").ResolveNodes(ctx));
        set => SetArgument("resource_ids", value);
    }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    [TerraformArgument("resource_provider")]
    public TerraformValue<string>? ResourceProvider
    {
        get => new TerraformReference<string>(this, "resource_provider");
        set => SetArgument("resource_provider", value);
    }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    [TerraformArgument("resource_providers")]
    public TerraformList<string>? ResourceProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_providers").ResolveNodes(ctx));
        set => SetArgument("resource_providers", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformArgument("resource_type")]
    public TerraformValue<string>? ResourceType
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformArgument("resource_types")]
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    [TerraformArgument("statuses")]
    public TerraformList<string>? Statuses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "statuses").ResolveNodes(ctx));
        set => SetArgument("statuses", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    [TerraformArgument("sub_status")]
    public TerraformValue<string>? SubStatus
    {
        get => new TerraformReference<string>(this, "sub_status");
        set => SetArgument("sub_status", value);
    }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    [TerraformArgument("sub_statuses")]
    public TerraformList<string>? SubStatuses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sub_statuses").ResolveNodes(ctx));
        set => SetArgument("sub_statuses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_monitor_activity_log_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorActivityLogAlert : TerraformResource
{
    public AzurermMonitorActivityLogAlert(string name) : base("azurerm_monitor_activity_log_alert", name)
    {
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
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformArgument("scopes")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("action")]
    public TerraformList<AzurermMonitorActivityLogAlertActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    [TerraformArgument("criteria")]
    public required TerraformList<AzurermMonitorActivityLogAlertCriteriaBlock> Criteria { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorActivityLogAlertTimeoutsBlock Timeouts { get; set; } = new();

}
