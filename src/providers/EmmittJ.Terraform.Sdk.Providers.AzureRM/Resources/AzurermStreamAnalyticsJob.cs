using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStreamAnalyticsJobIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for job_storage_account in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStreamAnalyticsJobJobStorageAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformProperty("account_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccountKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthenticationMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsJobTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStreamAnalyticsJob : TerraformResource
{
    public AzurermStreamAnalyticsJob(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformProperty("compatibility_level")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CompatibilityLevel { get; set; }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    [TerraformProperty("content_storage_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentStoragePolicy { get; set; }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformProperty("data_locale")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataLocale { get; set; }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformProperty("events_late_arrival_max_delay_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EventsLateArrivalMaxDelayInSeconds { get; set; }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformProperty("events_out_of_order_max_delay_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EventsOutOfOrderMaxDelayInSeconds { get; set; }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformProperty("events_out_of_order_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventsOutOfOrderPolicy { get; set; }

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
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformProperty("output_error_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutputErrorPolicy { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    [TerraformProperty("stream_analytics_cluster_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StreamAnalyticsClusterId { get; set; }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformProperty("streaming_units")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? StreamingUnits { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationQuery is required")]
    [TerraformProperty("transformation_query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransformationQuery { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermStreamAnalyticsJobIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for job_storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobStorageAccount block(s) allowed")]
    [TerraformProperty("job_storage_account")]
    public TerraformList<TerraformBlock<AzurermStreamAnalyticsJobJobStorageAccountBlock>>? JobStorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformProperty("job_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JobId { get; }

}
