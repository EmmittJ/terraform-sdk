using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock : ITerraformBlock
{
    /// <summary>
    /// A user-friendly description of the dataset.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the dataset.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FriendlyName { get; set; }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubListingSubscription : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListingSubscription(string name) : base("google_bigquery_analytics_hub_listing_subscription", name)
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
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for destination_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationDataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationDataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationDataset block(s) allowed")]
    [TerraformPropertyName("destination_dataset")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock>>? DestinationDataset { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    [TerraformPropertyName("commercial_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CommercialInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "commercial_info");

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    [TerraformPropertyName("last_modify_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifyTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modify_time");

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    [TerraformPropertyName("linked_dataset_map")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LinkedDatasetMap => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "linked_dataset_map");

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    [TerraformPropertyName("linked_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LinkedResources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "linked_resources");

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    [TerraformPropertyName("log_linked_dataset_query_user_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LogLinkedDatasetQueryUserEmail => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "log_linked_dataset_query_user_email");

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    [TerraformPropertyName("organization_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrganizationDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization_display_name");

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    [TerraformPropertyName("organization_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrganizationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization_id");

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    [TerraformPropertyName("subscriber_contact")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubscriberContact => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscriber_contact");

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubscriptionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscription_id");

}
