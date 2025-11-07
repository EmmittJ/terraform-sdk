using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? Location
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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? ResourceGroupName
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
