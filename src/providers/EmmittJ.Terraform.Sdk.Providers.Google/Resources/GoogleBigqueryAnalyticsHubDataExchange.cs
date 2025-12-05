using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for sharing_environment_config in GoogleBigqueryAnalyticsHubDataExchange.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sharing_environment_config";

    /// <summary>
    /// DcrExchangeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DcrExchangeConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDcrExchangeConfigBlock>? DcrExchangeConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDcrExchangeConfigBlock>>("dcr_exchange_config");
        set => SetArgument("dcr_exchange_config", value);
    }

    /// <summary>
    /// DefaultExchangeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultExchangeConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDefaultExchangeConfigBlock>? DefaultExchangeConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDefaultExchangeConfigBlock>>("default_exchange_config");
        set => SetArgument("default_exchange_config", value);
    }

}

/// <summary>
/// Block type for dcr_exchange_config in GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDcrExchangeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dcr_exchange_config";

}

/// <summary>
/// Block type for default_exchange_config in GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlockDefaultExchangeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_exchange_config";

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryAnalyticsHubDataExchange.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigquery_analytics_hub_data_exchange Terraform resource.
/// Manages a google_bigquery_analytics_hub_data_exchange resource.
/// </summary>
public partial class GoogleBigqueryAnalyticsHubDataExchange(string name) : TerraformResource("google_bigquery_analytics_hub_data_exchange", name)
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
    /// Description of the data exchange.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Type of discovery on the discovery page for all the listings under this exchange. Cannot be set for a Data Clean Room. Updating this field also updates (overwrites) the discoveryType field for all the listings under this exchange. Possible values: [&amp;quot;DISCOVERY_TYPE_PRIVATE&amp;quot;, &amp;quot;DISCOVERY_TYPE_PUBLIC&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiscoveryType
    {
        get => GetArgument<TerraformValue<string>>("discovery_type") ?? CreateReference("discovery_type");
        set => SetArgument("discovery_type", value);
    }

    /// <summary>
    /// Human-readable display name of the data exchange. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and must not start or end with spaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Documentation describing the data exchange.
    /// </summary>
    public TerraformValue<string>? Documentation
    {
        get => GetArgument<TerraformValue<string>>("documentation");
        set => SetArgument("documentation", value);
    }

    /// <summary>
    /// Base64 encoded image representing the data exchange.
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
    /// The name of the location this data exchange.
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
    /// Email or URL of the primary point of contact of the data exchange.
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
    /// Number of listings contained in the data exchange.
    /// </summary>
    public TerraformValue<double> ListingCount
        => CreateReference("listing_count");

    /// <summary>
    /// The resource name of the data exchange, for example:
    /// &amp;quot;projects/myproject/locations/US/dataExchanges/123&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// SharingEnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingEnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>? SharingEnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryAnalyticsHubDataExchangeSharingEnvironmentConfigBlock>>("sharing_environment_config");
        set => SetArgument("sharing_environment_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryAnalyticsHubDataExchangeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
