using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
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
    public TerraformBlock<AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Action => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "action");

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformPropertyName("authorized_resource_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AuthorizedResourceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "authorized_resource_ids");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformPropertyName("data_source_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_source_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Frequency => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "frequency");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformPropertyName("query")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Query => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "query");

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    [TerraformPropertyName("query_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QueryType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "query_type");

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Severity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "severity");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    [TerraformPropertyName("throttling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Throttling => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throttling");

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [TerraformPropertyName("time_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TimeWindow => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "time_window");

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    [TerraformPropertyName("trigger")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Trigger => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "trigger");

}
