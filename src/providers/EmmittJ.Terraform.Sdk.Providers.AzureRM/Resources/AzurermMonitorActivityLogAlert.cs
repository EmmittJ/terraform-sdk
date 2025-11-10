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
        set => SetProperty("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? WebhookProperties
    {
        set => SetProperty("webhook_properties", value);
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
        set => SetProperty("caller", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        set => SetProperty("level", value);
    }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Levels
    {
        set => SetProperty("levels", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string>? OperationName
    {
        set => SetProperty("operation_name", value);
    }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationCategory
    {
        set => SetProperty("recommendation_category", value);
    }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationImpact
    {
        set => SetProperty("recommendation_impact", value);
    }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    public TerraformProperty<string>? RecommendationType
    {
        set => SetProperty("recommendation_type", value);
    }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroup
    {
        set => SetProperty("resource_group", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceGroups
    {
        set => SetProperty("resource_groups", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceIds
    {
        set => SetProperty("resource_ids", value);
    }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceProvider
    {
        set => SetProperty("resource_provider", value);
    }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceProviders
    {
        set => SetProperty("resource_providers", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Statuses
    {
        set => SetProperty("statuses", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformProperty<string>? SubStatus
    {
        set => SetProperty("sub_status", value);
    }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SubStatuses
    {
        set => SetProperty("sub_statuses", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("scopes");
        SetOutput("tags");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActivityLogAlertActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public List<AzurermMonitorActivityLogAlertCriteriaBlock>? Criteria
    {
        set => SetProperty("criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorActivityLogAlertTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
