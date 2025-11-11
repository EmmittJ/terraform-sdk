using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for job_storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobJobStorageAccountBlock
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformPropertyName("account_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthenticationMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsJob : TerraformResource
{
    public AzurermStreamAnalyticsJob(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformPropertyName("compatibility_level")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CompatibilityLevel { get; set; } = default!;

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    [TerraformPropertyName("content_storage_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentStoragePolicy { get; set; }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformPropertyName("data_locale")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataLocale { get; set; }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_late_arrival_max_delay_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EventsLateArrivalMaxDelayInSeconds { get; set; }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_max_delay_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EventsOutOfOrderMaxDelayInSeconds { get; set; }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventsOutOfOrderPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformPropertyName("output_error_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutputErrorPolicy { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("stream_analytics_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StreamAnalyticsClusterId { get; set; }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformPropertyName("streaming_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StreamingUnits { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationQuery is required")]
    [TerraformPropertyName("transformation_query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TransformationQuery { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermStreamAnalyticsJobIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for job_storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobStorageAccount block(s) allowed")]
    [TerraformPropertyName("job_storage_account")]
    public TerraformList<TerraformBlock<AzurermStreamAnalyticsJobJobStorageAccountBlock>>? JobStorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobId => new TerraformReference(this, "job_id");

}
