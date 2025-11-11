using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActivityLogAlertActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    [TerraformProperty("action_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ActionGroupId { get; set; }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformProperty("webhook_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? WebhookProperties { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActivityLogAlertCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// The caller attribute.
    /// </summary>
    [TerraformProperty("caller")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Caller { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformProperty("level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Level { get; set; }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    [TerraformProperty("levels")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Levels { get; set; }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformProperty("operation_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OperationName { get; set; }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    [TerraformProperty("recommendation_category")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecommendationCategory { get; set; }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    [TerraformProperty("recommendation_impact")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecommendationImpact { get; set; }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    [TerraformProperty("recommendation_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecommendationType { get; set; }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    [TerraformProperty("resource_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceGroup { get; set; }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    [TerraformProperty("resource_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourceGroups { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceId { get; set; }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    [TerraformProperty("resource_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourceIds { get; set; }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    [TerraformProperty("resource_provider")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceProvider { get; set; }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    [TerraformProperty("resource_providers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourceProviders { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourceTypes { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    [TerraformProperty("statuses")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Statuses { get; set; }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    [TerraformProperty("sub_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubStatus { get; set; }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    [TerraformProperty("sub_statuses")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SubStatuses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorActivityLogAlertTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_activity_log_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorActivityLogAlert : TerraformResource
{
    public AzurermMonitorActivityLogAlert(string name) : base("azurerm_monitor_activity_log_alert", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Scopes { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action")]
    public TerraformList<TerraformBlock<AzurermMonitorActivityLogAlertActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    [TerraformProperty("criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorActivityLogAlertCriteriaBlock>>? Criteria { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorActivityLogAlertTimeoutsBlock>? Timeouts { get; set; }

}
