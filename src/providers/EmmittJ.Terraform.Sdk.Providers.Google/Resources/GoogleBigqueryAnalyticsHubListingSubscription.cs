using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock
{
    /// <summary>
    /// A user-friendly description of the dataset.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the dataset.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock
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
    public required TerraformValue<string> DataExchangeId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    [TerraformPropertyName("listing_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ListingId { get; set; }

    /// <summary>
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for destination_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationDataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationDataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationDataset block(s) allowed")]
    [TerraformPropertyName("destination_dataset")]
    public TerraformList<TerraformBlock<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock>>? DestinationDataset { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    [TerraformPropertyName("commercial_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CommercialInfo => new TerraformReference(this, "commercial_info");

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    [TerraformPropertyName("last_modify_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifyTime => new TerraformReference(this, "last_modify_time");

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    [TerraformPropertyName("linked_dataset_map")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LinkedDatasetMap => new TerraformReference(this, "linked_dataset_map");

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    [TerraformPropertyName("linked_resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LinkedResources => new TerraformReference(this, "linked_resources");

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    [TerraformPropertyName("log_linked_dataset_query_user_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LogLinkedDatasetQueryUserEmail => new TerraformReference(this, "log_linked_dataset_query_user_email");

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    [TerraformPropertyName("organization_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrganizationDisplayName => new TerraformReference(this, "organization_display_name");

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    [TerraformPropertyName("organization_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrganizationId => new TerraformReference(this, "organization_id");

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    [TerraformPropertyName("subscriber_contact")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriberContact => new TerraformReference(this, "subscriber_contact");

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriptionId => new TerraformReference(this, "subscription_id");

}
