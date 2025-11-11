using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationInsightsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_application_insights.
/// </summary>
public partial class AzurermApplicationInsightsDataSource : TerraformDataSource
{
    public AzurermApplicationInsightsDataSource(string name) : base("azurerm_application_insights", name)
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
    public TerraformBlock<AzurermApplicationInsightsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [TerraformProperty("app_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppId { get; }

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [TerraformProperty("application_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationType { get; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionString { get; }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformProperty("instrumentation_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstrumentationKey { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetentionInDays { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceId { get; }

}
