using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSignalrServiceCorsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AllowedOrigins { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSignalrServiceIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for live_trace in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSignalrServiceLiveTraceBlock : TerraformBlockBase
{
    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("connectivity_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("http_request_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("messaging_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MessagingLogsEnabled { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSignalrServiceSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSignalrServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upstream_endpoint in .
/// Nesting mode: set
/// </summary>
public partial class AzurermSignalrServiceUpstreamEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The category_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CategoryPattern is required")]
    [TerraformProperty("category_pattern")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? CategoryPattern { get; set; }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventPattern is required")]
    [TerraformProperty("event_pattern")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? EventPattern { get; set; }

    /// <summary>
    /// The hub_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubPattern is required")]
    [TerraformProperty("hub_pattern")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? HubPattern { get; set; }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformProperty("url_template")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UrlTemplate { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Manages a azurerm_signalr_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSignalrService : TerraformResource
{
    public AzurermSignalrService(string name) : base("azurerm_signalr_service", name)
    {
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("aad_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AadAuthEnabled { get; set; }

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("connectivity_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("http_request_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("live_trace_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LiveTraceEnabled { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("messaging_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MessagingLogsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("serverless_connection_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ServerlessConnectionTimeoutInSeconds { get; set; }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    [TerraformProperty("service_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_client_cert_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TlsClientCertEnabled { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cors")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for live_trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveTrace block(s) allowed")]
    [TerraformProperty("live_trace")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceLiveTraceBlock>>? LiveTrace { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSignalrServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upstream_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("upstream_endpoint")]
    public TerraformSet<TerraformBlock<AzurermSignalrServiceUpstreamEndpointBlock>>? UpstreamEndpoint { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformProperty("public_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PublicPort { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformProperty("server_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ServerPort { get; }

}
