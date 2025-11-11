using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceCorsBlock
{
    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformPropertyName("allowed_origins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AllowedOrigins { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for live_trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceLiveTraceBlock
{
    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_request_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("messaging_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MessagingLogsEnabled { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceSkuBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformPropertyName("capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upstream_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceUpstreamEndpointBlock
{
    /// <summary>
    /// The category_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CategoryPattern is required")]
    [TerraformPropertyName("category_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? CategoryPattern { get; set; }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventPattern is required")]
    [TerraformPropertyName("event_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? EventPattern { get; set; }

    /// <summary>
    /// The hub_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubPattern is required")]
    [TerraformPropertyName("hub_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? HubPattern { get; set; }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformPropertyName("url_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UrlTemplate { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Manages a azurerm_signalr_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSignalrService : TerraformResource
{
    public AzurermSignalrService(string name) : base("azurerm_signalr_service", name)
    {
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aad_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AadAuthEnabled { get; set; }

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_request_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("live_trace_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LiveTraceEnabled { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("messaging_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MessagingLogsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("serverless_connection_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ServerlessConnectionTimeoutInSeconds { get; set; }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    [TerraformPropertyName("service_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_client_cert_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsClientCertEnabled { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cors")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for live_trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveTrace block(s) allowed")]
    [TerraformPropertyName("live_trace")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceLiveTraceBlock>>? LiveTrace { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSignalrServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upstream_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("upstream_endpoint")]
    public TerraformSet<TerraformBlock<AzurermSignalrServiceUpstreamEndpointBlock>>? UpstreamEndpoint { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionString => new TerraformReference(this, "primary_connection_string");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformPropertyName("public_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PublicPort => new TerraformReference(this, "public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionString => new TerraformReference(this, "secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformPropertyName("server_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ServerPort => new TerraformReference(this, "server_port");

}
