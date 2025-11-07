using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub_socketio resource.
/// </summary>
public class AzurermWebPubsubSocketio : TerraformResource
{
    public AzurermWebPubsubSocketio(string name) : base("azurerm_web_pubsub_socketio", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("external_ip");
        this.DeclareOutput("hostname");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The live_trace_connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LiveTraceConnectivityLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("live_trace_connectivity_logs_enabled");
        set => this.WithProperty("live_trace_connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LiveTraceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("live_trace_enabled");
        set => this.WithProperty("live_trace_enabled", value);
    }

    /// <summary>
    /// The live_trace_http_request_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LiveTraceHttpRequestLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("live_trace_http_request_logs_enabled");
        set => this.WithProperty("live_trace_http_request_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_messaging_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LiveTraceMessagingLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("live_trace_messaging_logs_enabled");
        set => this.WithProperty("live_trace_messaging_logs_enabled", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
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
