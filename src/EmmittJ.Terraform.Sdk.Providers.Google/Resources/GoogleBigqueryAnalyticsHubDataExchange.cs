using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_analytics_hub_data_exchange resource.
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchange : TerraformResource
{
    public GoogleBigqueryAnalyticsHubDataExchange(string name) : base("google_bigquery_analytics_hub_data_exchange", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("listing_count");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public TerraformLiteralProperty<string>? DataExchangeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_exchange_id");
        set => this.WithProperty("data_exchange_id", value);
    }

    /// <summary>
    /// Description of the data exchange.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? DiscoveryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("discovery_type");
        set => this.WithProperty("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    public TerraformLiteralProperty<string>? Documentation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("documentation");
        set => this.WithProperty("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
    /// </summary>
    public TerraformLiteralProperty<string>? Icon
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon");
        set => this.WithProperty("icon", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the location this data exchange.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogLinkedDatasetQueryUserEmail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_linked_dataset_query_user_email");
        set => this.WithProperty("log_linked_dataset_query_user_email", value);
    }

    /// <summary>
    /// Email or URL of the primary point of contact of the data exchange.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryContact
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_contact");
        set => this.WithProperty("primary_contact", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Number of listings contained in the data exchange.
    /// </summary>
    public TerraformExpression ListingCount => this["listing_count"];

    /// <summary>
    /// The resource name of the data exchange, for example:
    /// &amp;quot;projects/myproject/locations/US/dataExchanges/123&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
