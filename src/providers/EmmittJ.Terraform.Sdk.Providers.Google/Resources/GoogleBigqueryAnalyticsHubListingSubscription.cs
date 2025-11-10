using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock : TerraformBlock
{
    /// <summary>
    /// A user-friendly description of the dataset.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A descriptive name for the dataset.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        set => SetProperty("friendly_name", value);
    }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubListingSubscription : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListingSubscription(string name) : base("google_bigquery_analytics_hub_listing_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("commercial_info");
        SetOutput("creation_time");
        SetOutput("last_modify_time");
        SetOutput("linked_dataset_map");
        SetOutput("linked_resources");
        SetOutput("log_linked_dataset_query_user_email");
        SetOutput("name");
        SetOutput("organization_display_name");
        SetOutput("organization_id");
        SetOutput("resource_type");
        SetOutput("state");
        SetOutput("subscriber_contact");
        SetOutput("subscription_id");
        SetOutput("data_exchange_id");
        SetOutput("id");
        SetOutput("listing_id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformProperty<string> DataExchangeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_exchange_id");
        set => SetProperty("data_exchange_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    public required TerraformProperty<string> ListingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("listing_id");
        set => SetProperty("listing_id", value);
    }

    /// <summary>
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for destination_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationDataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationDataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationDataset block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingSubscriptionDestinationDatasetBlock>? DestinationDataset
    {
        set => SetProperty("destination_dataset", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryAnalyticsHubListingSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    public TerraformExpression CommercialInfo => this["commercial_info"];

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    public TerraformExpression LastModifyTime => this["last_modify_time"];

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    public TerraformExpression LinkedDatasetMap => this["linked_dataset_map"];

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    public TerraformExpression LinkedResources => this["linked_resources"];

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    public TerraformExpression LogLinkedDatasetQueryUserEmail => this["log_linked_dataset_query_user_email"];

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    public TerraformExpression OrganizationDisplayName => this["organization_display_name"];

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    public TerraformExpression OrganizationId => this["organization_id"];

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    public TerraformExpression SubscriberContact => this["subscriber_contact"];

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    public TerraformExpression SubscriptionId => this["subscription_id"];

}
