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
    public bool? AadAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("aad_auth_enabled")?.Value;
        set => this.WithProperty("aad_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    public bool? ConnectivityLogsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("connectivity_logs_enabled")?.Value;
        set => this.WithProperty("connectivity_logs_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    public bool? HttpRequestLogsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("http_request_logs_enabled")?.Value;
        set => this.WithProperty("http_request_logs_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? LiveTraceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("live_trace_enabled")?.Value;
        set => this.WithProperty("live_trace_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public bool? LocalAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_auth_enabled")?.Value;
        set => this.WithProperty("local_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    public bool? MessagingLogsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("messaging_logs_enabled")?.Value;
        set => this.WithProperty("messaging_logs_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    public double? ServerlessConnectionTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("serverless_connection_timeout_in_seconds")?.Value;
        set => this.WithProperty("serverless_connection_timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    public string? ServiceMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_mode")?.Value;
        set => this.WithProperty("service_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public bool? TlsClientCertEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_client_cert_enabled")?.Value;
        set => this.WithProperty("tls_client_cert_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
