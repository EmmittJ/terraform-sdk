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
        SetOutput("listing_count");
        SetOutput("name");
        SetOutput("data_exchange_id");
        SetOutput("description");
        SetOutput("discovery_type");
        SetOutput("display_name");
        SetOutput("documentation");
        SetOutput("icon");
        SetOutput("id");
        SetOutput("location");
        SetOutput("log_linked_dataset_query_user_email");
        SetOutput("primary_contact");
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
    /// Description of the data exchange.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DiscoveryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("discovery_type");
        set => SetProperty("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    public TerraformProperty<string> Documentation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("documentation");
        set => SetProperty("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
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
    /// The name of the location this data exchange.
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
    /// Email or URL of the primary point of contact of the data exchange.
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
    /// Block for sharing_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingEnvironmentConfig block(s) allowed")]
    public List<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>? SharingEnvironmentConfig
    {
        set => SetProperty("sharing_environment_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
