using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock : ITerraformBlock
{
    /// <summary>
    /// Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformPropertyName("dataset")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Dataset { get; set; }

}

/// <summary>
/// Block type for data_provider in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingDataProviderBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the data provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Email or URL of the data provider.
    /// </summary>
    [TerraformPropertyName("primary_contact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryContact { get; set; }

}

/// <summary>
/// Block type for publisher in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPublisherBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the listing publisher.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Email or URL of the listing publisher.
    /// </summary>
    [TerraformPropertyName("primary_contact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryContact { get; set; }

}

/// <summary>
/// Block type for pubsub_topic in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPubsubTopicBlock : ITerraformBlock
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    [TerraformPropertyName("data_affinity_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataAffinityRegions { get; set; }

    /// <summary>
    /// Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Topic { get; set; }

}

/// <summary>
/// Block type for restricted_export_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If true, enable restricted export.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// If true, restrict direct table access(read api/tabledata.list) on linked table.
    /// </summary>
    [TerraformPropertyName("restrict_direct_table_access")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RestrictDirectTableAccess => new TerraformReferenceProperty<TerraformProperty<bool>>("", "restrict_direct_table_access");

    /// <summary>
    /// If true, restrict export of query result derived from restricted linked dataset table.
    /// </summary>
    [TerraformPropertyName("restrict_query_result")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestrictQueryResult { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingTimeoutsBlock : ITerraformBlock
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
/// Manages a google_bigquery_analytics_hub_listing resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubListing : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListing(string name) : base("google_bigquery_analytics_hub_listing", name)
    {
    }

    /// <summary>
    /// If true, the listing is only available to get the resource metadata. Listing is non subscribable.
    /// </summary>
    [TerraformPropertyName("allow_only_metadata_sharing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowOnlyMetadataSharing { get; set; }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    [TerraformPropertyName("categories")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Categories { get; set; }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    [TerraformPropertyName("data_exchange_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataExchangeId { get; set; }

    /// <summary>
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    [TerraformPropertyName("delete_commercial")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteCommercial { get; set; }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("discovery_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiscoveryType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "discovery_type");

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    [TerraformPropertyName("documentation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Documentation { get; set; }

    /// <summary>
    /// Base64 encoded image representing the listing.
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
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    [TerraformPropertyName("listing_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ListingId { get; set; }

    /// <summary>
    /// The name of the location this data exchange listing.
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
    /// Email or URL of the primary point of contact of the listing.
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
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    [TerraformPropertyName("request_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestAccess { get; set; }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDataset block(s) allowed")]
    [TerraformPropertyName("bigquery_dataset")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>>? BigqueryDataset { get; set; } = new();

    /// <summary>
    /// Block for data_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProvider block(s) allowed")]
    [TerraformPropertyName("data_provider")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingDataProviderBlock>>? DataProvider { get; set; } = new();

    /// <summary>
    /// Block for publisher.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Publisher block(s) allowed")]
    [TerraformPropertyName("publisher")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingPublisherBlock>>? Publisher { get; set; } = new();

    /// <summary>
    /// Block for pubsub_topic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTopic block(s) allowed")]
    [TerraformPropertyName("pubsub_topic")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>>? PubsubTopic { get; set; } = new();

    /// <summary>
    /// Block for restricted_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedExportConfig block(s) allowed")]
    [TerraformPropertyName("restricted_export_config")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>>? RestrictedExportConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryAnalyticsHubListingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// </summary>
    [TerraformPropertyName("commercial_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CommercialInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "commercial_info");

    /// <summary>
    /// The resource name of the listing. e.g. &amp;quot;projects/myproject/locations/US/dataExchanges/123/listings/456&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Current state of the listing.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
