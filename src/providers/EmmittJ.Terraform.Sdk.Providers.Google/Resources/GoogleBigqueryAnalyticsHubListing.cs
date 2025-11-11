using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformProperty("dataset")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Dataset { get; set; }

}

/// <summary>
/// Block type for data_provider in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingDataProviderBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the data provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Email or URL of the data provider.
    /// </summary>
    [TerraformProperty("primary_contact")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryContact { get; set; }

}

/// <summary>
/// Block type for publisher in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingPublisherBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the listing publisher.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Email or URL of the listing publisher.
    /// </summary>
    [TerraformProperty("primary_contact")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryContact { get; set; }

}

/// <summary>
/// Block type for pubsub_topic in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingPubsubTopicBlock : TerraformBlockBase
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    [TerraformProperty("data_affinity_regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DataAffinityRegions { get; set; }

    /// <summary>
    /// Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for restricted_export_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, enable restricted export.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }


    /// <summary>
    /// If true, restrict export of query result derived from restricted linked dataset table.
    /// </summary>
    [TerraformProperty("restrict_query_result")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestrictQueryResult { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_bigquery_analytics_hub_listing resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryAnalyticsHubListing : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListing(string name) : base("google_bigquery_analytics_hub_listing", name)
    {
    }

    /// <summary>
    /// If true, the listing is only available to get the resource metadata. Listing is non subscribable.
    /// </summary>
    [TerraformProperty("allow_only_metadata_sharing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowOnlyMetadataSharing { get; set; }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    [TerraformProperty("categories")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Categories { get; set; }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    [TerraformProperty("data_exchange_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataExchangeId { get; set; }

    /// <summary>
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    [TerraformProperty("delete_commercial")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteCommercial { get; set; }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    [TerraformProperty("discovery_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiscoveryType { get; set; }

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    [TerraformProperty("documentation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Documentation { get; set; }

    /// <summary>
    /// Base64 encoded image representing the listing.
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
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    [TerraformProperty("listing_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ListingId { get; set; }

    /// <summary>
    /// The name of the location this data exchange listing.
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
    /// Email or URL of the primary point of contact of the listing.
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
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    [TerraformProperty("request_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestAccess { get; set; }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDataset block(s) allowed")]
    [TerraformProperty("bigquery_dataset")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>>? BigqueryDataset { get; set; }

    /// <summary>
    /// Block for data_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProvider block(s) allowed")]
    [TerraformProperty("data_provider")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingDataProviderBlock>>? DataProvider { get; set; }

    /// <summary>
    /// Block for publisher.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Publisher block(s) allowed")]
    [TerraformProperty("publisher")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingPublisherBlock>>? Publisher { get; set; }

    /// <summary>
    /// Block for pubsub_topic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTopic block(s) allowed")]
    [TerraformProperty("pubsub_topic")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>>? PubsubTopic { get; set; }

    /// <summary>
    /// Block for restricted_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedExportConfig block(s) allowed")]
    [TerraformProperty("restricted_export_config")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>>? RestrictedExportConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigqueryAnalyticsHubListingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// </summary>
    [TerraformProperty("commercial_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CommercialInfo { get; }

    /// <summary>
    /// The resource name of the listing. e.g. &amp;quot;projects/myproject/locations/US/dataExchanges/123/listings/456&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Current state of the listing.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
