using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    public required TerraformProperty<string> ActionGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("action_group_id");
        set => WithProperty("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? WebhookProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("webhook_properties");
        set => WithProperty("webhook_properties", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The caller attribute.
    /// </summary>
    public TerraformProperty<string>? Caller
    {
        get => GetProperty<TerraformProperty<string>>("caller");
        set => WithProperty("caller", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredProperty<TerraformProperty<string>>("category");
        set => WithProperty("category", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        get => GetProperty<TerraformProperty<string>>("level");
        set => WithProperty("level", value);
    }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Levels
    {
        get => GetProperty<List<TerraformProperty<string>>>("levels");
        set => WithProperty("levels", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string>? OperationName
    {
        get => GetProperty<TerraformProperty<string>>("operation_name");
        set => WithProperty("operation_name", value);
    }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationCategory
    {
        get => GetProperty<TerraformProperty<string>>("recommendation_category");
        set => WithProperty("recommendation_category", value);
    }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationImpact
    {
        get => GetProperty<TerraformProperty<string>>("recommendation_impact");
        set => WithProperty("recommendation_impact", value);
    }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationType
    {
        get => GetProperty<TerraformProperty<string>>("recommendation_type");
        set => WithProperty("recommendation_type", value);
    }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroup
    {
        get => GetProperty<TerraformProperty<string>>("resource_group");
        set => WithProperty("resource_group", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_groups");
        set => WithProperty("resource_groups", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_ids");
        set => WithProperty("resource_ids", value);
    }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceProvider
    {
        get => GetProperty<TerraformProperty<string>>("resource_provider");
        set => WithProperty("resource_provider", value);
    }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceProviders
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_providers");
        set => WithProperty("resource_providers", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_types");
        set => WithProperty("resource_types", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Statuses
    {
        get => GetProperty<List<TerraformProperty<string>>>("statuses");
        set => WithProperty("statuses", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformProperty<string>? SubStatus
    {
        get => GetProperty<TerraformProperty<string>>("sub_status");
        set => WithProperty("sub_status", value);
    }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SubStatuses
    {
        get => GetProperty<List<TerraformProperty<string>>>("sub_statuses");
        set => WithProperty("sub_statuses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActivityLogAlertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActivityLogAlertActionBlock>? Action
    {
        get => GetProperty<List<AzurermMonitorActivityLogAlertActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public List<AzurermMonitorActivityLogAlertCriteriaBlock>? Criteria
    {
        get => GetProperty<List<AzurermMonitorActivityLogAlertCriteriaBlock>>("criteria");
        set => this.WithProperty("criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorActivityLogAlertTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorActivityLogAlertTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
