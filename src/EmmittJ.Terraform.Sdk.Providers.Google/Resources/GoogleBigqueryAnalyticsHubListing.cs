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
    public bool? AllowOnlyMetadataSharing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_only_metadata_sharing")?.Value;
        set => this.WithProperty("allow_only_metadata_sharing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Categories of the listing. Up to two categories are allowed.
    /// </summary>
    public List<string>? Categories
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("categories")?.Value;
        set => this.WithProperty("categories", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public string? DataExchangeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_exchange_id")?.Value;
        set => this.WithProperty("data_exchange_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.
    /// </summary>
    public bool? DeleteCommercial
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_commercial")?.Value;
        set => this.WithProperty("delete_commercial", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public string? DiscoveryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("discovery_type")?.Value;
        set => this.WithProperty("discovery_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;amp;) and can&#39;t start or end with spaces.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Documentation describing the listing.
    /// </summary>
    public string? Documentation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("documentation")?.Value;
        set => this.WithProperty("documentation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Base64 encoded image representing the listing.
    /// </summary>
    public string? Icon
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon")?.Value;
        set => this.WithProperty("icon", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public string? ListingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("listing_id")?.Value;
        set => this.WithProperty("listing_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the location this data exchange listing.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    public bool? LogLinkedDatasetQueryUserEmail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_linked_dataset_query_user_email")?.Value;
        set => this.WithProperty("log_linked_dataset_query_user_email", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Email or URL of the primary point of contact of the listing.
    /// </summary>
    public string? PrimaryContact
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_contact")?.Value;
        set => this.WithProperty("primary_contact", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Email or URL of the request access of the listing. Subscribers can use this reference to request access.
    /// </summary>
    public string? RequestAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_access")?.Value;
        set => this.WithProperty("request_access", value == null ? null : new TerraformLiteralProperty<string>(value));
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
