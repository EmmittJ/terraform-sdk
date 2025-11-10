using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceCorsBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for live_trace in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceLiveTraceBlock : TerraformBlock
{
    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ConnectivityLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("connectivity_logs_enabled");
        set => WithProperty("connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpRequestLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("http_request_logs_enabled");
        set => WithProperty("http_request_logs_enabled", value);
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MessagingLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("messaging_logs_enabled");
        set => WithProperty("messaging_logs_enabled", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Block type for upstream_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceUpstreamEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The category_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CategoryPattern is required")]
    public List<TerraformProperty<string>>? CategoryPattern
    {
        get => GetProperty<List<TerraformProperty<string>>>("category_pattern");
        set => WithProperty("category_pattern", value);
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventPattern is required")]
    public List<TerraformProperty<string>>? EventPattern
    {
        get => GetProperty<List<TerraformProperty<string>>>("event_pattern");
        set => WithProperty("event_pattern", value);
    }

    /// <summary>
    /// The hub_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubPattern is required")]
    public List<TerraformProperty<string>>? HubPattern
    {
        get => GetProperty<List<TerraformProperty<string>>>("hub_pattern");
        set => WithProperty("hub_pattern", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformProperty<string> UrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("url_template");
        set => WithProperty("url_template", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Manages a azurerm_signalr_service resource.
/// </summary>
public class AzurermSignalrService : TerraformResource
{
    public AzurermSignalrService(string name) : base("azurerm_signalr_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hostname");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("public_port");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("server_port");
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AadAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("aad_auth_enabled");
        set => this.WithProperty("aad_auth_enabled", value);
    }

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ConnectivityLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("connectivity_logs_enabled");
        set => this.WithProperty("connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpRequestLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("http_request_logs_enabled");
        set => this.WithProperty("http_request_logs_enabled", value);
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
    /// The live_trace_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? LiveTraceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("live_trace_enabled");
        set => this.WithProperty("live_trace_enabled", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MessagingLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("messaging_logs_enabled");
        set => this.WithProperty("messaging_logs_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ServerlessConnectionTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("serverless_connection_timeout_in_seconds");
        set => this.WithProperty("serverless_connection_timeout_in_seconds", value);
    }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceMode
    {
        get => GetProperty<TerraformProperty<string>>("service_mode");
        set => this.WithProperty("service_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsClientCertEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_client_cert_enabled");
        set => this.WithProperty("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSignalrServiceCorsBlock>? Cors
    {
        get => GetProperty<List<AzurermSignalrServiceCorsBlock>>("cors");
        set => this.WithProperty("cors", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermSignalrServiceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermSignalrServiceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for live_trace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveTrace block(s) allowed")]
    public List<AzurermSignalrServiceLiveTraceBlock>? LiveTrace
    {
        get => GetProperty<List<AzurermSignalrServiceLiveTraceBlock>>("live_trace");
        set => this.WithProperty("live_trace", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermSignalrServiceSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermSignalrServiceSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSignalrServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSignalrServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upstream_endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermSignalrServiceUpstreamEndpointBlock>? UpstreamEndpoint
    {
        get => GetProperty<HashSet<AzurermSignalrServiceUpstreamEndpointBlock>>("upstream_endpoint");
        set => this.WithProperty("upstream_endpoint", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    public TerraformExpression PublicPort => this["public_port"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformExpression ServerPort => this["server_port"];

}
