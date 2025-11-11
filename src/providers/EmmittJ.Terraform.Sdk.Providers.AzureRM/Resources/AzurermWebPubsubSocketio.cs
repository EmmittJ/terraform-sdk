using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebPubsubSocketioIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebPubsubSocketioSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebPubsubSocketioTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_pubsub_socketio resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermWebPubsubSocketio : TerraformResource
{
    public AzurermWebPubsubSocketio(string name) : base("azurerm_web_pubsub_socketio", name)
    {
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("aad_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AadAuthEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The live_trace_connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("live_trace_connectivity_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LiveTraceConnectivityLogsEnabled { get; set; }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [TerraformProperty("live_trace_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LiveTraceEnabled { get; set; }

    /// <summary>
    /// The live_trace_http_request_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("live_trace_http_request_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LiveTraceHttpRequestLogsEnabled { get; set; }

    /// <summary>
    /// The live_trace_messaging_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("live_trace_messaging_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LiveTraceMessagingLogsEnabled { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    [TerraformProperty("service_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_client_cert_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsClientCertEnabled { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermWebPubsubSocketioIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public partial TerraformList<TerraformBlock<AzurermWebPubsubSocketioSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermWebPubsubSocketioTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    [TerraformProperty("external_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalIp { get; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformProperty("public_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PublicPort { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformProperty("server_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ServerPort { get; }

}
