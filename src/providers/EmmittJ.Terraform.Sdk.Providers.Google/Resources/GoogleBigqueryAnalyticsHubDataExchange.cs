using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sharing_environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_analytics_hub_data_exchange resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryAnalyticsHubDataExchange : TerraformResource
{
    public GoogleBigqueryAnalyticsHubDataExchange(string name) : base("google_bigquery_analytics_hub_data_exchange", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("listing_count");
        this.WithOutput("name");
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformProperty<string> DataExchangeId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_exchange_id");
        set => this.WithProperty("data_exchange_id", value);
    }

    /// <summary>
    /// Description of the data exchange.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DiscoveryType
    {
        get => GetProperty<TerraformProperty<string>>("discovery_type");
        set => this.WithProperty("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    public TerraformProperty<string>? Documentation
    {
        get => GetProperty<TerraformProperty<string>>("documentation");
        set => this.WithProperty("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
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
    /// The name of the location this data exchange.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    /// Email or URL of the primary point of contact of the data exchange.
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
    /// Block for sharing_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingEnvironmentConfig block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>? SharingEnvironmentConfig
    {
        get => GetProperty<List<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>>("sharing_environment_config");
        set => this.WithProperty("sharing_environment_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
