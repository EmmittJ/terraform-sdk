using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioSkuBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubSocketioTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_pubsub_socketio resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWebPubsubSocketio : TerraformResource
{
    public AzurermWebPubsubSocketio(string name) : base("azurerm_web_pubsub_socketio", name)
    {
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aad_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AadAuthEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The live_trace_connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("live_trace_connectivity_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LiveTraceConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [TerraformPropertyName("live_trace_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LiveTraceEnabled { get; set; }

    /// <summary>
    /// The live_trace_http_request_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("live_trace_http_request_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LiveTraceHttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The live_trace_messaging_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("live_trace_messaging_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LiveTraceMessagingLogsEnabled { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    [TerraformPropertyName("service_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_client_cert_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsClientCertEnabled { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermWebPubsubSocketioIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermWebPubsubSocketioSkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebPubsubSocketioTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    [TerraformPropertyName("external_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_ip");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformPropertyName("public_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PublicPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformPropertyName("server_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ServerPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "server_port");

}
