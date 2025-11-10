using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_application_insights.
/// </summary>
public class AzurermApplicationInsightsDataSource : TerraformDataSource
{
    public AzurermApplicationInsightsDataSource(string name) : base("azurerm_application_insights", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationInsightsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_id");

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [TerraformPropertyName("application_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_type");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_string");

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformPropertyName("instrumentation_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstrumentationKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instrumentation_key");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetentionInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_in_days");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

}
