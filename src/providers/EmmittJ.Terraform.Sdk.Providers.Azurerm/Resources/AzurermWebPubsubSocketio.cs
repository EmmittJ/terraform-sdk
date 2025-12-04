using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermWebPubsubSocketio.
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for sku in AzurermWebPubsubSocketio.
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubSocketioSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWebPubsubSocketio.
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubSocketioTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_web_pubsub_socketio Terraform resource.
/// Manages a azurerm_web_pubsub_socketio resource.
/// </summary>
public partial class AzurermWebPubsubSocketio(string name) : TerraformResource("azurerm_web_pubsub_socketio", name)
{
    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AadAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("aad_auth_enabled");
        set => SetArgument("aad_auth_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The live_trace_connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LiveTraceConnectivityLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("live_trace_connectivity_logs_enabled");
        set => SetArgument("live_trace_connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LiveTraceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("live_trace_enabled");
        set => SetArgument("live_trace_enabled", value);
    }

    /// <summary>
    /// The live_trace_http_request_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LiveTraceHttpRequestLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("live_trace_http_request_logs_enabled");
        set => SetArgument("live_trace_http_request_logs_enabled", value);
    }

    /// <summary>
    /// The live_trace_messaging_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LiveTraceMessagingLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("live_trace_messaging_logs_enabled");
        set => SetArgument("live_trace_messaging_logs_enabled", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => GetArgument<TerraformValue<string>>("public_network_access");
        set => SetArgument("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_mode attribute.
    /// </summary>
    public TerraformValue<string>? ServiceMode
    {
        get => GetArgument<TerraformValue<string>>("service_mode");
        set => SetArgument("service_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsClientCertEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_client_cert_enabled");
        set => SetArgument("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    public TerraformValue<string> ExternalIp
        => AsReference("external_ip");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    public TerraformValue<double> PublicPort
        => AsReference("public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformValue<double> ServerPort
        => AsReference("server_port");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWebPubsubSocketioIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWebPubsubSocketioIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermWebPubsubSocketioSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermWebPubsubSocketioSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubSocketioTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubSocketioTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
