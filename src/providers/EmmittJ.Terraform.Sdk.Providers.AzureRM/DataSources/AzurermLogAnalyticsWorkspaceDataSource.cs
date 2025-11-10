using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace.
/// </summary>
public class AzurermLogAnalyticsWorkspaceDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceDataSource(string name) : base("azurerm_log_analytics_workspace", name)
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
    public TerraformBlock<AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    [TerraformPropertyName("daily_quota_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DailyQuotaGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "daily_quota_gb");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_shared_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimarySharedKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_shared_key");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetentionInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_in_days");

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_shared_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondarySharedKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_shared_key");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

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
