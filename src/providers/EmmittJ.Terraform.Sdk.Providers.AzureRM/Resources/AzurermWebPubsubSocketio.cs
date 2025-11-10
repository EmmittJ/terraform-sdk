using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubSocketioTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_web_pubsub_socketio resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWebPubsubSocketio : TerraformResource
{
    public AzurermWebPubsubSocketio(string name) : base("azurerm_web_pubsub_socketio", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("external_ip");
        SetOutput("hostname");
        SetOutput("primary_access_key");
        SetOutput("primary_connection_string");
        SetOutput("public_port");
        SetOutput("secondary_access_key");
        SetOutput("secondary_connection_string");
        SetOutput("server_port");
        SetOutput("aad_auth_enabled");
        SetOutput("id");
        SetOutput("live_trace_connectivity_logs_enabled");
        SetOutput("live_trace_enabled");
        SetOutput("live_trace_http_request_logs_enabled");
        SetOutput("live_trace_messaging_logs_enabled");
        SetOutput("local_auth_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_network_access");
        SetOutput("resource_group_name");
        SetOutput("service_mode");
        SetOutput("tags");
        SetOutput("tls_client_cert_enabled");
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AadAuthEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("aad_auth_enabled");
        set => SetProperty("aad_auth_enabled", value);
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
    /// The live_trace_connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LiveTraceConnectivityLogsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("live_trace_connectivity_logs_enabled");
        set => SetProperty("live_trace_connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LiveTraceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("live_trace_enabled");
        set => SetProperty("live_trace_enabled", value);
    }

    /// <summary>
    /// The live_trace_http_request_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LiveTraceHttpRequestLogsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("live_trace_http_request_logs_enabled");
        set => SetProperty("live_trace_http_request_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_messaging_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LiveTraceMessagingLogsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("live_trace_messaging_logs_enabled");
        set => SetProperty("live_trace_messaging_logs_enabled", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_auth_enabled");
        set => SetProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string> PublicNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_network_access");
        set => SetProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    public TerraformProperty<string> ServiceMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_mode");
        set => SetProperty("service_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TlsClientCertEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls_client_cert_enabled");
        set => SetProperty("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWebPubsubSocketioIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermWebPubsubSocketioSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubSocketioTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    public TerraformExpression ExternalIp => this["external_ip"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

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
