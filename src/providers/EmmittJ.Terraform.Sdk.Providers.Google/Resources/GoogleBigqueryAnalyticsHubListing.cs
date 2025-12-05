using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_dataset in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_dataset";

    /// <summary>
    /// Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// SelectedResources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlockSelectedResourcesBlock>? SelectedResources
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlockSelectedResourcesBlock>>("selected_resources");
        set => SetArgument("selected_resources", value);
    }

}

/// <summary>
/// Block type for selected_resources in GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlockSelectedResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_resources";

    /// <summary>
    /// Format: For table: projects/{projectId}/datasets/{datasetId}/tables/{tableId} Example:&amp;quot;projects/test_project/datasets/test_dataset/tables/test_table&amp;quot;
    /// </summary>
    public TerraformValue<string>? Table
    {
        get => GetArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

}


/// <summary>
/// Block type for data_provider in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingDataProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_provider";

    /// <summary>
    /// Name of the data provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Email or URL of the data provider.
    /// </summary>
    public TerraformValue<string>? PrimaryContact
    {
        get => GetArgument<TerraformValue<string>>("primary_contact");
        set => SetArgument("primary_contact", value);
    }

}


/// <summary>
/// Block type for publisher in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPublisherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publisher";

    /// <summary>
    /// Name of the listing publisher.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Email or URL of the listing publisher.
    /// </summary>
    public TerraformValue<string>? PrimaryContact
    {
        get => GetArgument<TerraformValue<string>>("primary_contact");
        set => SetArgument("primary_contact", value);
    }

}


/// <summary>
/// Block type for pubsub_topic in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingPubsubTopicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_topic";

    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    public TerraformSet<string>? DataAffinityRegions
    {
        get => GetArgument<TerraformSet<string>>("data_affinity_regions");
        set => SetArgument("data_affinity_regions", value);
    }

    /// <summary>
    /// Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for restricted_export_config in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restricted_export_config";

    /// <summary>
    /// If true, enable restricted export.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// If true, restrict direct table access(read api/tabledata.list) on linked table.
    /// </summary>
    public TerraformValue<bool> RestrictDirectTableAccess
        => CreateReference("restrict_direct_table_access");

    /// <summary>
    /// If true, restrict export of query result derived from restricted linked dataset table.
    /// </summary>
    public TerraformValue<bool>? RestrictQueryResult
    {
        get => GetArgument<TerraformValue<bool>>("restrict_query_result");
        set => SetArgument("restrict_query_result", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryAnalyticsHubListing.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubListingTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_analytics_hub_listing Terraform resource.
/// Manages a google_bigquery_analytics_hub_listing resource.
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListing(string name) : TerraformResource("google_bigquery_analytics_hub_listing", name)
{
    /// <summary>
    /// If true, the listing is only available to get the resource metadata. Listing is non subscribable.
    /// </summary>
    public TerraformValue<bool>? AllowOnlyMetadataSharing
    {
        get => GetArgument<TerraformValue<bool>>("allow_only_metadata_sharing");
        set => SetArgument("allow_only_metadata_sharing", value);
    }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    public TerraformList<string>? Categories
    {
        get => GetArgument<TerraformList<string>>("categories");
        set => SetArgument("categories", value);
    }

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
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    public TerraformValue<bool>? DeleteCommercial
    {
        get => GetArgument<TerraformValue<bool>>("delete_commercial");
        set => SetArgument("delete_commercial", value);
    }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiscoveryType
    {
        get => GetArgument<TerraformValue<string>>("discovery_type") ?? CreateReference("discovery_type");
        set => SetArgument("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    public TerraformValue<string>? Documentation
    {
        get => GetArgument<TerraformValue<string>>("documentation");
        set => SetArgument("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the listing.
    /// </summary>
    public TerraformValue<string>? Icon
    {
        get => GetArgument<TerraformValue<string>>("icon");
        set => SetArgument("icon", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The name of the location this data exchange listing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    public TerraformValue<bool>? LogLinkedDatasetQueryUserEmail
    {
        get => GetArgument<TerraformValue<bool>>("log_linked_dataset_query_user_email");
        set => SetArgument("log_linked_dataset_query_user_email", value);
    }

    /// <summary>
    /// Email or URL of the primary point of contact of the listing.
    /// </summary>
    public TerraformValue<string>? PrimaryContact
    {
        get => GetArgument<TerraformValue<string>>("primary_contact");
        set => SetArgument("primary_contact", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    public TerraformValue<string>? RequestAccess
    {
        get => GetArgument<TerraformValue<string>>("request_access");
        set => SetArgument("request_access", value);
    }

    /// <summary>
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// </summary>
    public TerraformList<TerraformMap<object>> CommercialInfo
        => CreateReference("commercial_info");

    /// <summary>
    /// The resource name of the listing. e.g. &amp;quot;projects/myproject/locations/US/dataExchanges/123/listings/456&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Current state of the listing.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// BigqueryDataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDataset block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>? BigqueryDataset
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingBigqueryDatasetBlock>>("bigquery_dataset");
        set => SetArgument("bigquery_dataset", value);
    }

    /// <summary>
    /// DataProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProvider block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubListingDataProviderBlock>? DataProvider
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingDataProviderBlock>>("data_provider");
        set => SetArgument("data_provider", value);
    }

    /// <summary>
    /// Publisher block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Publisher block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubListingPublisherBlock>? Publisher
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingPublisherBlock>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// PubsubTopic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTopic block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>? PubsubTopic
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingPubsubTopicBlock>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// RestrictedExportConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedExportConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>? RestrictedExportConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubListingRestrictedExportConfigBlock>>("restricted_export_config");
        set => SetArgument("restricted_export_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryAnalyticsHubListingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryAnalyticsHubListingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
