using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformArgument("allowed_origins")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for live_trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceLiveTraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_trace";

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("connectivity_logs_enabled")]
    public TerraformValue<bool>? ConnectivityLogsEnabled
    {
        get => new TerraformReference<bool>(this, "connectivity_logs_enabled");
        set => SetArgument("connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("http_request_logs_enabled")]
    public TerraformValue<bool>? HttpRequestLogsEnabled
    {
        get => new TerraformReference<bool>(this, "http_request_logs_enabled");
        set => SetArgument("http_request_logs_enabled", value);
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("messaging_logs_enabled")]
    public TerraformValue<bool>? MessagingLogsEnabled
    {
        get => new TerraformReference<bool>(this, "messaging_logs_enabled");
        set => SetArgument("messaging_logs_enabled", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformArgument("capacity")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for upstream_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceUpstreamEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upstream_endpoint";

    /// <summary>
    /// The category_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CategoryPattern is required")]
    [TerraformArgument("category_pattern")]
    public TerraformList<string>? CategoryPattern
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "category_pattern").ResolveNodes(ctx));
        set => SetArgument("category_pattern", value);
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventPattern is required")]
    [TerraformArgument("event_pattern")]
    public TerraformList<string>? EventPattern
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "event_pattern").ResolveNodes(ctx));
        set => SetArgument("event_pattern", value);
    }

    /// <summary>
    /// The hub_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubPattern is required")]
    [TerraformArgument("hub_pattern")]
    public TerraformList<string>? HubPattern
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "hub_pattern").ResolveNodes(ctx));
        set => SetArgument("hub_pattern", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformArgument("url_template")]
    public required TerraformValue<string> UrlTemplate
    {
        get => new TerraformReference<string>(this, "url_template");
        set => SetArgument("url_template", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

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
    [TerraformArgument("aad_auth_enabled")]
    public TerraformValue<bool>? AadAuthEnabled
    {
        get => new TerraformReference<bool>(this, "aad_auth_enabled");
        set => SetArgument("aad_auth_enabled", value);
    }

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("connectivity_logs_enabled")]
    public TerraformValue<bool>? ConnectivityLogsEnabled
    {
        get => new TerraformReference<bool>(this, "connectivity_logs_enabled");
        set => SetArgument("connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("http_request_logs_enabled")]
    public TerraformValue<bool>? HttpRequestLogsEnabled
    {
        get => new TerraformReference<bool>(this, "http_request_logs_enabled");
        set => SetArgument("http_request_logs_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("live_trace_enabled")]
    public TerraformValue<bool>? LiveTraceEnabled
    {
        get => new TerraformReference<bool>(this, "live_trace_enabled");
        set => SetArgument("live_trace_enabled", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("messaging_logs_enabled")]
    public TerraformValue<bool>? MessagingLogsEnabled
    {
        get => new TerraformReference<bool>(this, "messaging_logs_enabled");
        set => SetArgument("messaging_logs_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("serverless_connection_timeout_in_seconds")]
    public TerraformValue<double>? ServerlessConnectionTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "serverless_connection_timeout_in_seconds");
        set => SetArgument("serverless_connection_timeout_in_seconds", value);
    }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    [TerraformArgument("service_mode")]
    public TerraformValue<string>? ServiceMode
    {
        get => new TerraformReference<string>(this, "service_mode");
        set => SetArgument("service_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_client_cert_enabled")]
    public TerraformValue<bool>? TlsClientCertEnabled
    {
        get => new TerraformReference<bool>(this, "tls_client_cert_enabled");
        set => SetArgument("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("cors")]
    public TerraformList<AzurermSignalrServiceCorsBlock> Cors { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermSignalrServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for live_trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveTrace block(s) allowed")]
    [TerraformArgument("live_trace")]
    public TerraformList<AzurermSignalrServiceLiveTraceBlock> LiveTrace { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermSignalrServiceSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSignalrServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upstream_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("upstream_endpoint")]
    public TerraformSet<AzurermSignalrServiceUpstreamEndpointBlock> UpstreamEndpoint { get; set; } = new();

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformArgument("hostname")]
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_connection_string")]
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformArgument("public_port")]
    public TerraformValue<double> PublicPort
    {
        get => new TerraformReference<double>(this, "public_port");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_connection_string")]
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformArgument("server_port")]
    public TerraformValue<double> ServerPort
    {
        get => new TerraformReference<double>(this, "server_port");
    }

}
