using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_dataset in GoogleBigqueryAnalyticsHubListingSubscription.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_dataset";

    /// <summary>
    /// A user-friendly description of the dataset.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A descriptive name for the dataset.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// DatasetReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatasetReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatasetReference block(s) allowed")]
    public required TerraformList<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlockDatasetReferenceBlock> DatasetReference
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlockDatasetReferenceBlock>>("dataset_reference");
        set => SetArgument("dataset_reference", value);
    }

}

/// <summary>
/// Block type for dataset_reference in GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlockDatasetReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset_reference";

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryAnalyticsHubListingSubscription.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_bigquery_analytics_hub_listing_subscription Terraform resource.
/// Manages a google_bigquery_analytics_hub_listing_subscription resource.
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingSubscription(string name) : TerraformResource("google_bigquery_analytics_hub_listing_subscription", name)
{
    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformValue<string> DataExchangeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_exchange_id");
        set => SetArgument("data_exchange_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    public required TerraformValue<string> ListingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("listing_id");
        set => SetArgument("listing_id", value);
    }

    /// <summary>
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    public TerraformList<TerraformMap<object>> CommercialInfo
        => AsReference("commercial_info");

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    public TerraformValue<string> LastModifyTime
        => AsReference("last_modify_time");

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    public TerraformSet<TerraformMap<object>> LinkedDatasetMap
        => AsReference("linked_dataset_map");

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinkedResources
        => AsReference("linked_resources");

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    public TerraformValue<bool> LogLinkedDatasetQueryUserEmail
        => AsReference("log_linked_dataset_query_user_email");

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    public TerraformValue<string> OrganizationDisplayName
        => AsReference("organization_display_name");

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    public TerraformValue<string> OrganizationId
        => AsReference("organization_id");

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    public TerraformValue<string> SubscriberContact
        => AsReference("subscriber_contact");

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    public TerraformValue<string> SubscriptionId
        => AsReference("subscription_id");

    /// <summary>
    /// DestinationDataset block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationDataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationDataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationDataset block(s) allowed")]
    public required TerraformList<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock> DestinationDataset
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock>>("destination_dataset");
        set => SetArgument("destination_dataset", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
