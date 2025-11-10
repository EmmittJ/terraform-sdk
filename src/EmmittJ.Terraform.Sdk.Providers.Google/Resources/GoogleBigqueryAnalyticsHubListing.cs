using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetProperty<TerraformProperty<string>>("dataset");
        set => WithProperty("dataset", value);
    }

}

/// <summary>
/// Block type for data_provider in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingDataProviderBlock : TerraformBlock
{
    /// <summary>
    /// Name of the data provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Email or URL of the data provider.
    /// </summary>
    public TerraformProperty<string>? PrimaryContact
    {
        get => GetProperty<TerraformProperty<string>>("primary_contact");
        set => WithProperty("primary_contact", value);
    }

}

/// <summary>
/// Block type for publisher in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPublisherBlock : TerraformBlock
{
    /// <summary>
    /// Name of the listing publisher.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Email or URL of the listing publisher.
    /// </summary>
    public TerraformProperty<string>? PrimaryContact
    {
        get => GetProperty<TerraformProperty<string>>("primary_contact");
        set => WithProperty("primary_contact", value);
    }

}

/// <summary>
/// Block type for pubsub_topic in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPubsubTopicBlock : TerraformBlock
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataAffinityRegions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_affinity_regions");
        set => WithProperty("data_affinity_regions", value);
    }

    /// <summary>
    /// Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for restricted_export_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock : TerraformBlock
{
    /// <summary>
    /// If true, enable restricted export.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// If true, restrict direct table access(read api/tabledata.list) on linked table.
    /// </summary>
    public TerraformProperty<bool>? RestrictDirectTableAccess
    {
        get => GetProperty<TerraformProperty<bool>>("restrict_direct_table_access");
        set => WithProperty("restrict_direct_table_access", value);
    }

    /// <summary>
    /// If true, restrict export of query result derived from restricted linked dataset table.
    /// </summary>
    public TerraformProperty<bool>? RestrictQueryResult
    {
        get => GetProperty<TerraformProperty<bool>>("restrict_query_result");
        set => WithProperty("restrict_query_result", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing resource.
/// </summary>
public class GoogleBigqueryAnalyticsHubListing : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListing(string name) : base("google_bigquery_analytics_hub_listing", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("commercial_info");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// If true, the listing is only available to get the resource metadata. Listing is non subscribable.
    /// </summary>
    public TerraformProperty<bool>? AllowOnlyMetadataSharing
    {
        get => GetProperty<TerraformProperty<bool>>("allow_only_metadata_sharing");
        set => this.WithProperty("allow_only_metadata_sharing", value);
    }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    public List<TerraformProperty<string>>? Categories
    {
        get => GetProperty<List<TerraformProperty<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformProperty<string> DataExchangeId
    {
        get => GetProperty<TerraformProperty<string>>("data_exchange_id");
        set => this.WithProperty("data_exchange_id", value);
    }

    /// <summary>
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    public TerraformProperty<bool>? DeleteCommercial
    {
        get => GetProperty<TerraformProperty<bool>>("delete_commercial");
        set => this.WithProperty("delete_commercial", value);
    }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DiscoveryType
    {
        get => GetProperty<TerraformProperty<string>>("discovery_type");
        set => this.WithProperty("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    public TerraformProperty<string>? Documentation
    {
        get => GetProperty<TerraformProperty<string>>("documentation");
        set => this.WithProperty("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the listing.
    /// </summary>
    public TerraformProperty<string>? Icon
    {
        get => GetProperty<TerraformProperty<string>>("icon");
        set => this.WithProperty("icon", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    public required TerraformProperty<string> ListingId
    {
        get => GetProperty<TerraformProperty<string>>("listing_id");
        set => this.WithProperty("listing_id", value);
    }

    /// <summary>
    /// The name of the location this data exchange listing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    public TerraformProperty<bool>? LogLinkedDatasetQueryUserEmail
    {
        get => GetProperty<TerraformProperty<bool>>("log_linked_dataset_query_user_email");
        set => this.WithProperty("log_linked_dataset_query_user_email", value);
    }

    /// <summary>
    /// Email or URL of the primary point of contact of the listing.
    /// </summary>
    public TerraformProperty<string>? PrimaryContact
    {
        get => GetProperty<TerraformProperty<string>>("primary_contact");
        set => this.WithProperty("primary_contact", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    public TerraformProperty<string>? RequestAccess
    {
        get => GetProperty<TerraformProperty<string>>("request_access");
        set => this.WithProperty("request_access", value);
    }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDataset block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>? BigqueryDataset
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>>("bigquery_dataset");
        set => this.WithProperty("bigquery_dataset", value);
    }

    /// <summary>
    /// Block for data_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProvider block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingDataProviderBlock>? DataProvider
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubListingDataProviderBlock>>("data_provider");
        set => this.WithProperty("data_provider", value);
    }

    /// <summary>
    /// Block for publisher.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Publisher block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingPublisherBlock>? Publisher
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubListingPublisherBlock>>("publisher");
        set => this.WithProperty("publisher", value);
    }

    /// <summary>
    /// Block for pubsub_topic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTopic block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>? PubsubTopic
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>>("pubsub_topic");
        set => this.WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Block for restricted_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedExportConfig block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>? RestrictedExportConfig
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>>("restricted_export_config");
        set => this.WithProperty("restricted_export_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryAnalyticsHubListingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryAnalyticsHubListingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// </summary>
    public TerraformExpression CommercialInfo => this["commercial_info"];

    /// <summary>
    /// The resource name of the listing. e.g. &amp;quot;projects/myproject/locations/US/dataExchanges/123/listings/456&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Current state of the listing.
    /// </summary>
    public TerraformExpression State => this["state"];

}
