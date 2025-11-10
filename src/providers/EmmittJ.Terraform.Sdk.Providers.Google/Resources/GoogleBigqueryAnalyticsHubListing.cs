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
        set => SetProperty("dataset", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Email or URL of the data provider.
    /// </summary>
    public TerraformProperty<string>? PrimaryContact
    {
        set => SetProperty("primary_contact", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Email or URL of the listing publisher.
    /// </summary>
    public TerraformProperty<string>? PrimaryContact
    {
        set => SetProperty("primary_contact", value);
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
        set => SetProperty("data_affinity_regions", value);
    }

    /// <summary>
    /// Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        set => SetProperty("topic", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// If true, restrict direct table access(read api/tabledata.list) on linked table.
    /// </summary>
    public TerraformProperty<bool>? RestrictDirectTableAccess
    {
        set => SetProperty("restrict_direct_table_access", value);
    }

    /// <summary>
    /// If true, restrict export of query result derived from restricted linked dataset table.
    /// </summary>
    public TerraformProperty<bool>? RestrictQueryResult
    {
        set => SetProperty("restrict_query_result", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubListing : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListing(string name) : base("google_bigquery_analytics_hub_listing", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("commercial_info");
        SetOutput("name");
        SetOutput("state");
        SetOutput("allow_only_metadata_sharing");
        SetOutput("categories");
        SetOutput("data_exchange_id");
        SetOutput("delete_commercial");
        SetOutput("description");
        SetOutput("discovery_type");
        SetOutput("display_name");
        SetOutput("documentation");
        SetOutput("icon");
        SetOutput("id");
        SetOutput("listing_id");
        SetOutput("location");
        SetOutput("log_linked_dataset_query_user_email");
        SetOutput("primary_contact");
        SetOutput("project");
        SetOutput("request_access");
    }

    /// <summary>
    /// If true, the listing is only available to get the resource metadata. Listing is non subscribable.
    /// </summary>
    public TerraformProperty<bool> AllowOnlyMetadataSharing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_only_metadata_sharing");
        set => SetProperty("allow_only_metadata_sharing", value);
    }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    public List<TerraformProperty<string>> Categories
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("categories");
        set => SetProperty("categories", value);
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
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    public TerraformProperty<bool> DeleteCommercial
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_commercial");
        set => SetProperty("delete_commercial", value);
    }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DiscoveryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("discovery_type");
        set => SetProperty("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    public TerraformProperty<string> Documentation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("documentation");
        set => SetProperty("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the listing.
    /// </summary>
    public TerraformProperty<string> Icon
    {
        get => GetRequiredOutput<TerraformProperty<string>>("icon");
        set => SetProperty("icon", value);
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
    /// The name of the location this data exchange listing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    public TerraformProperty<bool> LogLinkedDatasetQueryUserEmail
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_linked_dataset_query_user_email");
        set => SetProperty("log_linked_dataset_query_user_email", value);
    }

    /// <summary>
    /// Email or URL of the primary point of contact of the listing.
    /// </summary>
    public TerraformProperty<string> PrimaryContact
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_contact");
        set => SetProperty("primary_contact", value);
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
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    public TerraformProperty<string> RequestAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_access");
        set => SetProperty("request_access", value);
    }

    /// <summary>
    /// Block for bigquery_dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDataset block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>? BigqueryDataset
    {
        set => SetProperty("bigquery_dataset", value);
    }

    /// <summary>
    /// Block for data_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProvider block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingDataProviderBlock>? DataProvider
    {
        set => SetProperty("data_provider", value);
    }

    /// <summary>
    /// Block for publisher.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Publisher block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingPublisherBlock>? Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// Block for pubsub_topic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTopic block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>? PubsubTopic
    {
        set => SetProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Block for restricted_export_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedExportConfig block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>? RestrictedExportConfig
    {
        set => SetProperty("restricted_export_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryAnalyticsHubListingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
