using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_dataset in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock() : TerraformBlock("destination_dataset")
{
    /// <summary>
    /// A user-friendly description of the dataset.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the dataset.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryAnalyticsHubListingSubscription : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListingSubscription(string name) : base("google_bigquery_analytics_hub_listing_subscription", name)
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
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for destination_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationDataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationDataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationDataset block(s) allowed")]
    [TerraformProperty("destination_dataset")]
    public required TerraformList<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock> DestinationDataset { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    [TerraformProperty("commercial_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CommercialInfo { get; }

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    [TerraformProperty("last_modify_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifyTime { get; }

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    [TerraformProperty("linked_dataset_map")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LinkedDatasetMap { get; }

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    [TerraformProperty("linked_resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LinkedResources { get; }

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    [TerraformProperty("log_linked_dataset_query_user_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LogLinkedDatasetQueryUserEmail { get; }

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    [TerraformProperty("organization_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OrganizationDisplayName { get; }

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    [TerraformProperty("organization_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OrganizationId { get; }

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceType { get; }

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    [TerraformProperty("subscriber_contact")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriberContact { get; }

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriptionId { get; }

}
