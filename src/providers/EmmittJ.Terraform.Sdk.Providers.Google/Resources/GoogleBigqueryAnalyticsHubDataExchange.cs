using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sharing_environment_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock() : TerraformBlock("sharing_environment_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_data_exchange resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryAnalyticsHubDataExchange : TerraformResource
{
    public GoogleBigqueryAnalyticsHubDataExchange(string name) : base("google_bigquery_analytics_hub_data_exchange", name)
    {
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    [TerraformProperty("data_exchange_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataExchangeId { get; set; }

    /// <summary>
    /// Description of the data exchange.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    [TerraformProperty("discovery_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiscoveryType { get; set; }

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    [TerraformProperty("documentation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Documentation { get; set; }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
    /// </summary>
    [TerraformProperty("icon")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Icon { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the location this data exchange.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    [TerraformProperty("log_linked_dataset_query_user_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>
    /// Email or URL of the primary point of contact of the data exchange.
    /// </summary>
    [TerraformProperty("primary_contact")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryContact { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for sharing_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingEnvironmentConfig block(s) allowed")]
    [TerraformProperty("sharing_environment_config")]
    public TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock> SharingEnvironmentConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Number of listings contained in the data exchange.
    /// </summary>
    [TerraformProperty("listing_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ListingCount { get; }

    /// <summary>
    /// The resource name of the data exchange, for example:
    /// &amp;quot;projects/myproject/locations/US/dataExchanges/123&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
