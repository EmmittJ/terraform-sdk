using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesLogDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_log.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesLogDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesLogDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_log", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorScheduledQueryRulesLogDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformProperty("authorized_resource_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AuthorizedResourceIds { get; }

    /// <summary>
    /// The criteria attribute.
    /// </summary>
    [TerraformProperty("criteria")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Criteria { get; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformProperty("data_source_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataSourceId { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
