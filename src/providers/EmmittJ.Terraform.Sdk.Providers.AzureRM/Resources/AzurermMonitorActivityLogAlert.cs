using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertActionBlock : ITerraformBlock
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    [TerraformPropertyName("action_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ActionGroupId { get; set; }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformPropertyName("webhook_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? WebhookProperties { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActivityLogAlertCriteriaBlock : ITerraformBlock
{
    /// <summary>
    /// The caller attribute.
    /// </summary>
    [TerraformPropertyName("caller")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Caller { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Category { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformPropertyName("level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Level { get; set; }

    /// <summary>
    /// The levels attribute.
    /// </summary>
    [TerraformPropertyName("levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Levels { get; set; }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformPropertyName("operation_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OperationName { get; set; }

    /// <summary>
    /// The recommendation_category attribute.
    /// </summary>
    [TerraformPropertyName("recommendation_category")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecommendationCategory { get; set; }

    /// <summary>
    /// The recommendation_impact attribute.
    /// </summary>
    [TerraformPropertyName("recommendation_impact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecommendationImpact { get; set; }

    /// <summary>
    /// The recommendation_type attribute.
    /// </summary>
    [TerraformPropertyName("recommendation_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecommendationType { get; set; }

    /// <summary>
    /// The resource_group attribute.
    /// </summary>
    [TerraformPropertyName("resource_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceGroup { get; set; }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    [TerraformPropertyName("resource_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResourceGroups { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceId { get; set; }

    /// <summary>
    /// The resource_ids attribute.
    /// </summary>
    [TerraformPropertyName("resource_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResourceIds { get; set; }

    /// <summary>
    /// The resource_provider attribute.
    /// </summary>
    [TerraformPropertyName("resource_provider")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceProvider { get; set; }

    /// <summary>
    /// The resource_providers attribute.
    /// </summary>
    [TerraformPropertyName("resource_providers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResourceProviders { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceType { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResourceTypes { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    [TerraformPropertyName("statuses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Statuses { get; set; }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    [TerraformPropertyName("sub_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubStatus { get; set; }

    /// <summary>
    /// The sub_statuses attribute.
    /// </summary>
    [TerraformPropertyName("sub_statuses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SubStatuses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActivityLogAlertTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AzurermMonitorActivityLogAlertActionBlock>>? Action { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    [TerraformPropertyName("criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorActivityLogAlertCriteriaBlock>>? Criteria { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorActivityLogAlertTimeoutsBlock>? Timeouts { get; set; } = new();

}
