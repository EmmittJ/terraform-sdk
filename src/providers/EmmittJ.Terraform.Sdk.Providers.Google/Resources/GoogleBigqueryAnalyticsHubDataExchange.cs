using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sharing_environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_data_exchange resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubDataExchange : TerraformResource
{
    public GoogleBigqueryAnalyticsHubDataExchange(string name) : base("google_bigquery_analytics_hub_data_exchange", name)
    {
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    [TerraformPropertyName("data_exchange_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataExchangeId { get; set; }

    /// <summary>
    /// Description of the data exchange.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("discovery_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiscoveryType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "discovery_type");

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    [TerraformPropertyName("documentation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Documentation { get; set; }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
    /// </summary>
    [TerraformPropertyName("icon")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Icon { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the location this data exchange.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    [TerraformPropertyName("log_linked_dataset_query_user_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>
    /// Email or URL of the primary point of contact of the data exchange.
    /// </summary>
    [TerraformPropertyName("primary_contact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryContact { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for sharing_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingEnvironmentConfig block(s) allowed")]
    [TerraformPropertyName("sharing_environment_config")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>>? SharingEnvironmentConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Number of listings contained in the data exchange.
    /// </summary>
    [TerraformPropertyName("listing_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ListingCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "listing_count");

    /// <summary>
    /// The resource name of the data exchange, for example:
    /// &amp;quot;projects/myproject/locations/US/dataExchanges/123&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
