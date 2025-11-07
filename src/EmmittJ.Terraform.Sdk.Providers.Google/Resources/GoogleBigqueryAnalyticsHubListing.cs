using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<List<string>>? Categories
    {
        get => GetProperty<TerraformProperty<List<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public TerraformProperty<string>? DataExchangeId
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
    public TerraformProperty<string>? DisplayName
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
    public TerraformProperty<string>? ListingId
    {
        get => GetProperty<TerraformProperty<string>>("listing_id");
        set => this.WithProperty("listing_id", value);
    }

    /// <summary>
    /// The name of the location this data exchange listing.
    /// </summary>
    public TerraformProperty<string>? Location
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
